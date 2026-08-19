// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmExtractTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The CSV watermark control parameters. These must be consistent with the parameters used during embedding. Otherwise, extraction fails.</para>
        /// </summary>
        [NameInMap("CsvControl")]
        [Validation(Required=false)]
        public string CsvControlShrink { get; set; }

        /// <summary>
        /// <para>The document watermark parameter that specifies whether the file to be extracted is a screenshot of a document with a background watermark. The service determines whether to use the document background watermark extraction logic based on whether the file is an image file. Therefore, this parameter does not need to be set by default. Valid values:</para>
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
        /// <para>The URL used to download the file from which the watermark is to be fetched. The URL must be accessible over the public network access.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/test-****.pdf">https://example.com/test-****.pdf</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The name of the file from which the watermark is to be extracted. The backend determines and validates the file type based on the file name extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-****.pdf</para>
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// <para>The image extraction parameters.</para>
        /// </summary>
        [NameInMap("ImageExtractParamsOpenApi")]
        [Validation(Required=false)]
        public string ImageExtractParamsOpenApiShrink { get; set; }

        /// <summary>
        /// <para>The audio watermark parameter that specifies whether the watermark was embedded by the client SDK. Default value: false. Valid values:</para>
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
        /// <para>The video watermark parameter that specifies whether to use the long video watermark SDK. Default value: false. Valid values:</para>
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
        /// <para>The long video watermark parameter that specifies the video playback speed as a floating-point string. Default value: 1, which indicates the playback speed used when the watermark was added, or the speed at which the video timeline was stretched after the watermark was added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VideoSpeed")]
        [Validation(Required=false)]
        public string VideoSpeed { get; set; }

        /// <summary>
        /// <para>The bit width of the watermark information capacity. Default value: 32. This parameter must be consistent between embedding and extraction. For example, if the 40-bit SDK was used for embedding, set this value to 40 for extraction.</para>
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
        /// <item><description><b>PureWebappInvisible</b>: web page watermark.</description></item>
        /// <item><description><b>PureAppInvisible</b>: app watermark.</description></item>
        /// <item><description><b>PureScreenInvisible</b>: screen watermark.</description></item>
        /// <item><description><b>PureDocument</b>: document watermark.</description></item>
        /// <item><description><b>PureImage</b>: image watermark.</description></item>
        /// <item><description><b>PureAudio</b>: audio watermark.</description></item>
        /// <item><description><b>PureVideo</b>: video watermark.</description></item>
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
