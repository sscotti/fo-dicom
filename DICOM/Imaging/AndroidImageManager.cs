﻿// Copyright (c) 2012-2021 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

namespace Dicom.Imaging
{
    using Dicom.IO;

    /// <summary>
    /// Windows Forms-based image manager implementation.
    /// </summary>
    public sealed class AndroidImageManager : ImageManager
    {
        #region FIELDS

        /// <summary>
        /// Single instance of the Windows Forms image manager.
        /// </summary>
        public static readonly ImageManager Instance;

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Initializes the static fields of <see cref="AndroidImageManager"/>
        /// </summary>
        static AndroidImageManager()
        {
            Instance = new AndroidImageManager();
        }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets whether or not this type is classified as a default manager.
        /// </summary>
        public override bool IsDefault
        {
            get
            {
                return true;
            }
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Create <see cref="IImage"/> object using the current implementation.
        /// </summary>
        /// <param name="width">Image width.</param>
        /// <param name="height">Image height.</param>
        /// <returns><see cref="IImage"/> object using the current implementation.</returns>
        protected override IImage CreateImageImpl(int width, int height)
        {
            return new AndroidImage(width, height);
        }

        #endregion
    }
}
