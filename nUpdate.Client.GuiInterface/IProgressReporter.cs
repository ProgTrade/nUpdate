﻿using System;

namespace nUpdate.UpdateInstaller.Client.GuiInterface
{
    public interface IProgressReporter
    {
        /// <summary>
        ///     The initializing-method that loads the necessary resources.
        /// </summary>
        void Initialize();

        /// <summary>
        ///     Reports the progress of the updating process.
        /// </summary>
        /// <param name="progress">The current progress percentage.</param>
        /// <param name="currentFile">The current file that is being copied to the computer.</param>
        void ReportUnpackingProgress(int progress, string currentFile);

        /// <summary>
        ///     Reports the progress of the updating process when the operations are executed.
        /// </summary>
        /// <param name="progress">The current progress percentage.</param>
        /// <param name="currentOperation">The current file that is being copied to the computer.</param>
        void ReportOperationProgress(int progress, string currentOperation);

        /// <summary>
        ///     Reports exceptions that occur during the updating process.
        /// </summary>
        /// <param name="ex">The current exception that occured.</param>
        /// <returns>Returns 'true' if the updating process should continue though, otherwise 'false'.</returns>
        bool Fail(Exception ex);

        /// <summary>
        ///     Terminates the updating process.
        /// </summary>
        void Terminate();
    }
}