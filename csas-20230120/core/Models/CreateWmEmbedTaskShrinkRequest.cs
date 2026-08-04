// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmEmbedTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Audio control parameters.</para>
        /// </summary>
        [NameInMap("AudioControl")]
        [Validation(Required=false)]
        public string AudioControlShrink { get; set; }

        /// <summary>
        /// <para>CSV watermark embedding control parameters.</para>
        /// </summary>
        [NameInMap("CsvControl")]
        [Validation(Required=false)]
        public string CsvControlShrink { get; set; }

        /// <summary>
        /// <para>Document watermark control parameters.</para>
        /// </summary>
        [NameInMap("DocumentControl")]
        [Validation(Required=false)]
        public string DocumentControlShrink { get; set; }

        /// <summary>
        /// <para>URL for downloading the file to embed. The URL must support public network access.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/abc****.pdf">https://example.com/abc****.pdf</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The filename of the file to embed. The backend validates the file type based on the filename extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc****.pdf</para>
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// <para>Image watermark control parameters.</para>
        /// </summary>
        [NameInMap("ImageControl")]
        [Validation(Required=false)]
        public string ImageControlShrink { get; set; }

        /// <summary>
        /// <para>Image watermark parameter: the desired JPEG compression quality factor for the output image. Default value is 95. Valid range: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95</para>
        /// </summary>
        [NameInMap("ImageEmbedJpegQuality")]
        [Validation(Required=false)]
        public long? ImageEmbedJpegQuality { get; set; }

        /// <summary>
        /// <para>Image watermark parameter: A higher value indicates greater robustness but reduced visual quality. Default value: 2. Valid values: 0 to 4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ImageEmbedLevel")]
        [Validation(Required=false)]
        public long? ImageEmbedLevel { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable invisible watermark embedding. Default value: true.<br>Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes  </description></item>
        /// <item><description><b>false</b>: No</description></item>
        /// </list>
        /// </summary>
        [NameInMap("InvisibleEnable")]
        [Validation(Required=false)]
        public bool? InvisibleEnable { get; set; }

        /// <summary>
        /// <para>Short video watermark parameter: specifies the video bitrate. By default, the video bitrate is automatically retrieved. You can use this parameter to explicitly specify the bitrate used during extraction. This parameter usually does not need to be set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000k</para>
        /// </summary>
        [NameInMap("VideoBitrate")]
        [Validation(Required=false)]
        public string VideoBitrate { get; set; }

        /// <summary>
        /// <para>Video control parameters.</para>
        /// </summary>
        [NameInMap("VideoControl")]
        [Validation(Required=false)]
        public string VideoControlShrink { get; set; }

        /// <summary>
        /// <para>Video watermark parameter: whether to use the long-video watermark software development kit (SDK). The default value is false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes</description></item>
        /// <item><description><b>false</b>: No</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VideoIsLong")]
        [Validation(Required=false)]
        public bool? VideoIsLong { get; set; }

        /// <summary>
        /// <para>Base64-encoded string-formatted watermark information. If this value is set, WmInfoUint cannot be set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aGVsbG8gc2F*****</para>
        /// </summary>
        [NameInMap("WmInfoBytesB64")]
        [Validation(Required=false)]
        public string WmInfoBytesB64 { get; set; }

        /// <summary>
        /// <para>The bit width of the watermark information. The default value is 32. This parameter must be consistent between embedding and extraction. For example, if a 40-bit software development kit (SDK) is used for embedding, this value must also be set to 40 during extraction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("WmInfoSize")]
        [Validation(Required=false)]
        public long? WmInfoSize { get; set; }

        /// <summary>
        /// <para>Watermark information in decimal numeric format. If this parameter is set, WmInfoBytesB64 cannot be set.  </para>
        /// <para>The valid value range depends on the WmInfoSize parameter:  </para>
        /// <list type="bullet">
        /// <item><description><para>When WmInfoSize is 32, the value range is 1 to 4294967295.  </para>
        /// </description></item>
        /// <item><description><para>When WmInfoSize is 40, the value range is 1 to 1099511627775.  </para>
        /// </description></item>
        /// <item><description><para>When WmInfoSize is 64, the value range is 1 to 18446744073709551615.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>123***</para>
        /// </summary>
        [NameInMap("WmInfoUint")]
        [Validation(Required=false)]
        public string WmInfoUint { get; set; }

        /// <summary>
        /// <para>Watermark type. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>PureDocument</b>: Document watermark.  </description></item>
        /// <item><description><b>PureImage</b>: Image watermark.  </description></item>
        /// <item><description><b>PureAudio</b>: Audio watermark.  </description></item>
        /// <item><description><b>PureVideo</b>: Video watermark.  </description></item>
        /// <item><description><b>AigcDocument</b>: AIGC document watermark.  </description></item>
        /// <item><description><b>AigcImage</b>: AIGC image watermark.  </description></item>
        /// <item><description><b>AigcAudio</b>: AIGC audio watermark.  </description></item>
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
