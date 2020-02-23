using System;

namespace CPrint.Models.ViewModels
{
    // for errors
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
