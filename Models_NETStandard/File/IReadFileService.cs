﻿using Models.Translation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.File
{
    /// <summary>
    /// Object to read a file
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IReadFileService<T> : IService
    {
        /// <summary>
        /// Read a readable file and returns type T model for that file
        /// </summary>
        /// <returns>Read file in type T</returns>
        T Read(String filePath);
    }
}
