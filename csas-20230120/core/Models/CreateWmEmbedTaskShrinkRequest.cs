// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmEmbedTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The audio control parameters.</para>
        /// </summary>
        [NameInMap("AudioControl")]
        [Validation(Required=false)]
        public string AudioControlShrink { get; set; }

        /// <summary>
        /// <para>The CSV watermark embedding control parameters.</para>
        /// </summary>
        [NameInMap("CsvControl")]
        [Validation(Required=false)]
        public string CsvControlShrink { get; set; }

        /// <summary>
        /// <para>The document watermark control parameters.</para>
        /// </summary>
        [NameInMap("DocumentControl")]
        [Validation(Required=false)]
        public string DocumentControlShrink { get; set; }

        /// <summary>
        /// <para>The URL for downloading the file to be embedded. The URL must be active for public network access.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/abc****.pdf">https://example.com/abc****.pdf</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The name of the file to be embedded. The backend validates the file type based on the file name extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc****.pdf</para>
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// <para>The image watermark control parameters.</para>
        /// </summary>
        [NameInMap("ImageControl")]
        [Validation(Required=false)]
        public string ImageControlShrink { get; set; }

        /// <summary>
        /// <para>The image watermark parameter that specifies the expected JPEG compression quality factor of the output image. Default value: 95. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95</para>
        /// </summary>
        [NameInMap("ImageEmbedJpegQuality")]
        [Validation(Required=false)]
        public long? ImageEmbedJpegQuality { get; set; }

        /// <summary>
        /// <para>The image watermark parameter. A larger value indicates higher robustness but lower visual quality. Default value: 2. Valid values: 0 to 4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ImageEmbedLevel")]
        [Validation(Required=false)]
        public long? ImageEmbedLevel { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable invisible watermark embedding. Default value: true.</para>
        /// </summary>
        [NameInMap("InvisibleEnable")]
        [Validation(Required=false)]
        public bool? InvisibleEnable { get; set; }

        /// <summary>
        /// <para>The short video watermark parameter that specifies the video bitrate. By default, the video bitrate is automatically obtained. You can use this parameter to forcibly specify the bitrate used during extraction. Typically, you do not need to set this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000k</para>
        /// </summary>
        [NameInMap("VideoBitrate")]
        [Validation(Required=false)]
        public string VideoBitrate { get; set; }

        /// <summary>
        /// <para>The video control parameters.</para>
        /// </summary>
        [NameInMap("VideoControl")]
        [Validation(Required=false)]
        public string VideoControlShrink { get; set; }

        /// <summary>
        /// <para>Video watermark parameter. Specifies whether to use the long video watermark SDK. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The long video watermark SDK is used.</description></item>
        /// <item><description><b>false</b>: The long video watermark SDK is not used.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VideoIsLong")]
        [Validation(Required=false)]
        public bool? VideoIsLong { get; set; }

        /// <summary>
        /// <para>The watermark information in Base64-encoded string format. If this parameter is set, WmInfoUint cannot be set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aGVsbG8gc2F*****</para>
        /// </summary>
        [NameInMap("WmInfoBytesB64")]
        [Validation(Required=false)]
        public string WmInfoBytesB64 { get; set; }

        /// <summary>
        /// <para>The bit width of the watermark information capacity. Default value: 32. This parameter must be consistent between embedding and extraction. For example, if the 40-bit SDK is used for embedding, set this parameter to 40 during extraction as well.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("WmInfoSize")]
        [Validation(Required=false)]
        public long? WmInfoSize { get; set; }

        /// <summary>
        /// <para>The watermark information in decimal number format. If this parameter is set, WmInfoBytesB64 cannot be set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123***</para>
        /// </summary>
        [NameInMap("WmInfoUint")]
        [Validation(Required=false)]
        public string WmInfoUint { get; set; }

        /// <summary>
        /// <para>The watermark type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PureDocument</b>: document watermark.</description></item>
        /// <item><description><b>PureImage</b>: image watermark.</description></item>
        /// <item><description><b>PureAudio</b>: audio watermark.</description></item>
        /// <item><description><b>PureVideo</b>: video watermark.</description></item>
        /// <item><description><b>AigcDocument</b>: AIGC document watermark.</description></item>
        /// <item><description><b>AigcImage</b>: AIGC image watermark.</description></item>
        /// <item><description><b>AigcAudio</b>: AIGC audio watermark.</description></item>
        /// <item><description><b>AigcVideo</b>: AIGC video watermark.</description></item>
        /// </list>
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
