// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmEmbedTaskRequest : TeaModel {
        [NameInMap("DocumentControl")]
        [Validation(Required=false)]
        public CreateWmEmbedTaskRequestDocumentControl DocumentControl { get; set; }
        public class CreateWmEmbedTaskRequestDocumentControl : TeaModel {
            [NameInMap("BackgroundControl")]
            [Validation(Required=false)]
            public CreateWmEmbedTaskRequestDocumentControlBackgroundControl BackgroundControl { get; set; }
            public class CreateWmEmbedTaskRequestDocumentControlBackgroundControl : TeaModel {
                [NameInMap("BgAddInvisible")]
                [Validation(Required=false)]
                public bool? BgAddInvisible { get; set; }

                [NameInMap("BgAddVisible")]
                [Validation(Required=false)]
                public bool? BgAddVisible { get; set; }

                [NameInMap("BgInvisibleControl")]
                [Validation(Required=false)]
                public CreateWmEmbedTaskRequestDocumentControlBackgroundControlBgInvisibleControl BgInvisibleControl { get; set; }
                public class CreateWmEmbedTaskRequestDocumentControlBackgroundControlBgInvisibleControl : TeaModel {
                    [NameInMap("Opacity")]
                    [Validation(Required=false)]
                    public long? Opacity { get; set; }

                }

                [NameInMap("BgVisibleControl")]
                [Validation(Required=false)]
                public CreateWmEmbedTaskRequestDocumentControlBackgroundControlBgVisibleControl BgVisibleControl { get; set; }
                public class CreateWmEmbedTaskRequestDocumentControlBackgroundControlBgVisibleControl : TeaModel {
                    [NameInMap("Angle")]
                    [Validation(Required=false)]
                    public long? Angle { get; set; }

                    [NameInMap("FontColor")]
                    [Validation(Required=false)]
                    public string FontColor { get; set; }

                    [NameInMap("FontSize")]
                    [Validation(Required=false)]
                    public long? FontSize { get; set; }

                    [NameInMap("HorizontalNumber")]
                    [Validation(Required=false)]
                    public long? HorizontalNumber { get; set; }

                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    [NameInMap("Opacity")]
                    [Validation(Required=false)]
                    public long? Opacity { get; set; }

                    [NameInMap("PosX")]
                    [Validation(Required=false)]
                    public string PosX { get; set; }

                    [NameInMap("PosY")]
                    [Validation(Required=false)]
                    public string PosY { get; set; }

                    [NameInMap("VerticalNumber")]
                    [Validation(Required=false)]
                    public long? VerticalNumber { get; set; }

                    [NameInMap("VisibleText")]
                    [Validation(Required=false)]
                    public string VisibleText { get; set; }

                }

            }

            [NameInMap("InvisibleAntiAllCopy")]
            [Validation(Required=false)]
            public bool? InvisibleAntiAllCopy { get; set; }

            [NameInMap("InvisibleAntiTextCopy")]
            [Validation(Required=false)]
            public bool? InvisibleAntiTextCopy { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        [NameInMap("ImageEmbedJpegQuality")]
        [Validation(Required=false)]
        public long? ImageEmbedJpegQuality { get; set; }

        [NameInMap("ImageEmbedLevel")]
        [Validation(Required=false)]
        public long? ImageEmbedLevel { get; set; }

        [NameInMap("VideoBitrate")]
        [Validation(Required=false)]
        public string VideoBitrate { get; set; }

        [NameInMap("VideoIsLong")]
        [Validation(Required=false)]
        public bool? VideoIsLong { get; set; }

        [NameInMap("WmInfoBytesB64")]
        [Validation(Required=false)]
        public string WmInfoBytesB64 { get; set; }

        [NameInMap("WmInfoSize")]
        [Validation(Required=false)]
        public long? WmInfoSize { get; set; }

        [NameInMap("WmInfoUint")]
        [Validation(Required=false)]
        public string WmInfoUint { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WmType")]
        [Validation(Required=false)]
        public string WmType { get; set; }

    }

}
