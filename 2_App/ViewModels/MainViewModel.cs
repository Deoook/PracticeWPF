using _2_App.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System.IO;

namespace _2_App.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private Note _currentNote = new Note();
        public Note CurrentNote
        {
            get => _currentNote;
            set => SetProperty(ref _currentNote, value);
        }

        private string _windowTitle = "MVVM Notepad";
        public string WindowTitle
        {
            get => _windowTitle;
            set => SetProperty(ref _windowTitle, value);
        }

        public RelayCommand NewFileCommand { get; }
        public RelayCommand OpenFileCommand { get; }
        public RelayCommand SaveFileCommand { get; }

        public MainViewModel()
        {
            NewFileCommand = new RelayCommand(NewFile);
            OpenFileCommand = new RelayCommand(OpenFile);
            SaveFileCommand = new RelayCommand(SaveFile);
        }

        private void NewFile()
        {
            CurrentNote = new Note();
            WindowTitle = "New File - MVVM Notepad";
        }

        private void OpenFile()
        {
            var dialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };

            if (dialog.ShowDialog() == true)
            {
                CurrentNote.strFilePath = dialog.FileName;
                CurrentNote.strContent = File.ReadAllText(dialog.FileName);
                WindowTitle = $"{Path.GetFileName(dialog.FileName)} - MVVM Notepad";
            }
        }

        private void SaveFile()
        {
            if (string.IsNullOrWhiteSpace(CurrentNote.strFilePath))
            {
                var dialog = new SaveFileDialog
                {
                    Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
                };

                if (dialog.ShowDialog() == true)
                {
                    CurrentNote.strFilePath = dialog.FileName;
                }
            }

            if (!string.IsNullOrWhiteSpace(CurrentNote.strFilePath))
            {
                File.WriteAllText(CurrentNote.strFilePath, CurrentNote.strContent);
                WindowTitle = $"{Path.GetFileName(CurrentNote.strFilePath)} - MVVM Notepad";
            }
        }
    }
}
