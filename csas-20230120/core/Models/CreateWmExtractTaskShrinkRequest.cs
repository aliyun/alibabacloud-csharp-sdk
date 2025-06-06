// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmExtractTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The CSV watermark control parameter. You must keep the value of this parameter consistent for watermark embedding and watermark extraction. Otherwise, the extraction fails.</para>
        /// </summary>
        [NameInMap("CsvControl")]
        [Validation(Required=false)]
        public string CsvControlShrink { get; set; }

        /// <summary>
        /// <para>The document watermark parameter that specifies whether the file to be extracted is a screenshot of a document with a background watermark added. The system determines whether to use the extraction logic for document background watermarks based on whether the file to be extracted is an image file. By default, you do not need to configure this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DocumentIsCapture")]
        [Validation(Required=false)]
        public bool? DocumentIsCapture { get; set; }

        /// <summary>
        /// <para>The URL used to download the file to be extracted. The URL must be accessible over the Internet.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/test-****.pdf">https://example.com/test-****.pdf</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The name of the file to be extracted. The system needs to check the file type based on the file name extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-****.pdf</para>
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        [NameInMap("IsClientEmbed")]
        [Validation(Required=false)]
        public bool? IsClientEmbed { get; set; }

        /// <summary>
        /// <para>The watermark parameter for videos that specifies whether to use the long video watermark SDK. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VideoIsLong")]
        [Validation(Required=false)]
        public bool? VideoIsLong { get; set; }

        /// <summary>
        /// <para>The watermark parameter for long videos that specifies the video speed factor. The value can be a floating-point number or a string. Default value: 1. This parameter indicates the speed at which a watermark is added or the time-stretching rate for videos after a watermark is added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VideoSpeed")]
        [Validation(Required=false)]
        public string VideoSpeed { get; set; }

        /// <summary>
        /// <para>The watermark information size. Default value: 32. You must keep the value of this parameter consistent for watermark embedding and watermark extraction. For example, if a 40-bit watermark is used for watermark embedding, you must set this parameter to 40 for watermark extraction.</para>
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
        /// <item><description><b>PureWebappInvisible</b>: web page watermark</description></item>
        /// <item><description><b>PureAppInvisible</b>: app watermark</description></item>
        /// <item><description><b>PureScreenInvisible</b>: screen watermark</description></item>
        /// <item><description><b>PureDocument</b>: document watermark</description></item>
        /// <item><description><b>PureImage</b>: image watermark</description></item>
        /// <item><description><b>PureAudio</b>: audio watermark</description></item>
        /// <item><description><b>PureVideo</b>: video watermark</description></item>
        /// <item><description><b>AigcWebappInvisible</b>: artificial intelligence generated content (AIGC)-based webpage watermark</description></item>
        /// <item><description><b>AigcAppInvisible</b>: AIGC-based app watermark</description></item>
        /// <item><description><b>AigcScreenInvisible</b>: AIGC-based screen watermark</description></item>
        /// <item><description><b>AigcDocument</b>: AIGC-based document watermark</description></item>
        /// <item><description><b>AigcImage</b>: AIGC-based image watermark</description></item>
        /// <item><description><b>AigcAudio</b>: AIGC-based audio watermark</description></item>
        /// <item><description><b>AigcVideo</b>: AIGC-based video watermark</description></item>
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
