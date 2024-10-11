// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetDigitalWatermarkExtractResultRequest : TeaModel {
        /// <summary>
        /// <para>The type of the watermark. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TraceMark</b>: user-tracing watermark</description></item>
        /// <item><description><b>CopyrightMark</b>: copyright watermark</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TraceMark</para>
        /// </summary>
        [NameInMap("ExtractType")]
        [Validation(Required=false)]
        public string ExtractType { get; set; }

        /// <summary>
        /// <para>The ID of the watermark extraction job.</para>
        /// <list type="bullet">
        /// <item><description>You can obtain the ID from the response to the <a href="~~SubmitDigitalWatermarkExtractJob~~">SubmitDigitalWatermarkExtractJob</a> operation.</description></item>
        /// <item><description>If you specify this parameter, the result of the specified watermark extraction job is returned. If you leave this parameter empty, the results of all watermark extraction jobs submitted for the video are returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2bf4390af9e5491c09cc720ad****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The ID of the video from which you want to query the watermark content. You can specify only one ID. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the video ID.</description></item>
        /// <item><description>Obtain the VideoId from the response to the <a href="~~SearchMedia~~">SearchMedia</a> operation.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93ab850b4f6f54b6e91d24d81d4****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public string ResourceOwnerId { get; set; }

    }

}
