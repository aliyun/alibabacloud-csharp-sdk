// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmEmbedTaskShrinkRequest : TeaModel {
        [NameInMap("AudioControl")]
        [Validation(Required=false)]
        public string AudioControlShrink { get; set; }

        [NameInMap("CsvControl")]
        [Validation(Required=false)]
        public string CsvControlShrink { get; set; }

        [NameInMap("DocumentControl")]
        [Validation(Required=false)]
        public string DocumentControlShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/abc****.pdf">https://example.com/abc****.pdf</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc****.pdf</para>
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        [NameInMap("ImageControl")]
        [Validation(Required=false)]
        public string ImageControlShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>95</para>
        /// </summary>
        [NameInMap("ImageEmbedJpegQuality")]
        [Validation(Required=false)]
        public long? ImageEmbedJpegQuality { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ImageEmbedLevel")]
        [Validation(Required=false)]
        public long? ImageEmbedLevel { get; set; }

        [NameInMap("InvisibleEnable")]
        [Validation(Required=false)]
        public bool? InvisibleEnable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3000k</para>
        /// </summary>
        [NameInMap("VideoBitrate")]
        [Validation(Required=false)]
        public string VideoBitrate { get; set; }

        [NameInMap("VideoControl")]
        [Validation(Required=false)]
        public string VideoControlShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VideoIsLong")]
        [Validation(Required=false)]
        public bool? VideoIsLong { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aGVsbG8gc2F*****</para>
        /// </summary>
        [NameInMap("WmInfoBytesB64")]
        [Validation(Required=false)]
        public string WmInfoBytesB64 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("WmInfoSize")]
        [Validation(Required=false)]
        public long? WmInfoSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123***</para>
        /// </summary>
        [NameInMap("WmInfoUint")]
        [Validation(Required=false)]
        public string WmInfoUint { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PureDocument</para>
        /// </summary>
        [NameInMap("WmType")]
        [Validation(Required=false)]
        public string WmType { get; set; }

    }

}
