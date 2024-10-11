// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitDigitalWatermarkExtractJobRequest : TeaModel {
        /// <summary>
        /// <para>The type of the watermark that you want to extract. Valid values:</para>
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
        /// <para>The ID of the video from which you want to extract the watermark. You can specify only one ID. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the video ID.</description></item>
        /// <item><description>Obtain the VideoId from the response to the <a href="~~SearchMedia~~">SearchMedia</a> operation.</description></item>
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
