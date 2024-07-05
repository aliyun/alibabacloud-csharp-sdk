// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitDigitalWatermarkExtractJobRequest : TeaModel {
        /// <summary>
        /// The type of the watermark that you want to extract. Valid values:
        /// 
        /// *   **TraceMark**: user-tracing watermark
        /// *   **CopyrightMark**: copyright watermark
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExtractType")]
        [Validation(Required=false)]
        public string ExtractType { get; set; }

        /// <summary>
        /// The ID of the video from which you want to extract the watermark. You can specify only one ID. You can use one of the following methods to obtain the ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Media Files** > **Audio/Video** to view the video ID.
        /// *   Obtain the VideoId from the response to the [SearchMedia](~~SearchMedia~~) operation.
        /// 
        /// This parameter is required.
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
