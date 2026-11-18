// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitDigitalWatermarkExtractJobRequest : TeaModel {
        /// <summary>
        /// <para>The type of the watermark to extract. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TraceMark</b>: tracing watermark.</description></item>
        /// <item><description><b>CopyrightMark</b>: copyright watermark.</description></item>
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
        /// <para>The ID of the video from which you want to extract the watermark. You can specify only one video ID. You can obtain the video ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Assets</b> &gt; <b>Audio and Video</b> to view the video ID.</description></item>
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/436559.html">SearchMedia</a> operation and obtain the video ID from the VideoId parameter in the response.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0222e203cf80f9c22870a4d2c****</para>
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
