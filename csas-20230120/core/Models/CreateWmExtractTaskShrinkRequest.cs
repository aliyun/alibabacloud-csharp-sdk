// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmExtractTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>CSV watermark control parameters. These parameters must be consistent with those used during embedding. Otherwise, the extraction fails.</para>
        /// </summary>
        [NameInMap("CsvControl")]
        [Validation(Required=false)]
        public string CsvControlShrink { get; set; }

        /// <summary>
        /// <para>Document watermark parameter. Specifies whether the file from which the watermark is to be extracted is a screenshot of a document with a background watermark. The service determines whether to use the document background watermark extraction logic based on whether the file is an image file. Therefore, you do not need to set this parameter by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DocumentIsCapture")]
        [Validation(Required=false)]
        public bool? DocumentIsCapture { get; set; }

        /// <summary>
        /// <para>The URL used to download the file to be fetched. The URL must support public network access.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/test-****.pdf">https://example.com/test-****.pdf</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The name of the file from which the watermark is to be extracted. The backend determines and verifies the file type based on the file name extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-****.pdf</para>
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// <para>Image extraction parameters.</para>
        /// </summary>
        [NameInMap("ImageExtractParamsOpenApi")]
        [Validation(Required=false)]
        public string ImageExtractParamsOpenApiShrink { get; set; }

        /// <summary>
        /// <para>Audio watermark parameter. Specifies whether the watermark is embedded by using the client SDK. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsClientEmbed")]
        [Validation(Required=false)]
        public bool? IsClientEmbed { get; set; }

        /// <summary>
        /// <para>Video watermark parameter. Specifies whether to use the long video watermark SDK. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VideoIsLong")]
        [Validation(Required=false)]
        public bool? VideoIsLong { get; set; }

        /// <summary>
        /// <para>Long video watermark parameter. The video playback speed, represented as a floating-point string. Default value: 1. This value represents the playback speed used when adding the watermark, or the timeline stretching speed after the watermark is added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VideoSpeed")]
        [Validation(Required=false)]
        public string VideoSpeed { get; set; }

        /// <summary>
        /// <para>The bit width of the watermark information capacity. Default value: 32. This parameter must be consistent during embedding and extraction. For example, if a 40-bit SDK is used for embedding, you must also set this value to 40 for extraction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("WmInfoSize")]
        [Validation(Required=false)]
        public long? WmInfoSize { get; set; }

        /// <summary>
        /// <para>The watermark type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PureWebappInvisible</b>: Web page watermark.</description></item>
        /// <item><description><b>PureAppInvisible</b>: App watermark.</description></item>
        /// <item><description><b>PureScreenInvisible</b>: Screen watermark.</description></item>
        /// <item><description><b>PureDocument</b>: Document watermark.</description></item>
        /// <item><description><b>PureImage</b>: Image watermark.</description></item>
        /// <item><description><b>PureAudio</b>: Audio watermark.</description></item>
        /// <item><description><b>PureVideo</b>: Video watermark.</description></item>
        /// <item><description><b>AigcWebappInvisible</b>: AIGC web page watermark.</description></item>
        /// <item><description><b>AigcAppInvisible</b>: AIGC app watermark.</description></item>
        /// <item><description><b>AigcScreenInvisible</b>: AIGC screen watermark.</description></item>
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
