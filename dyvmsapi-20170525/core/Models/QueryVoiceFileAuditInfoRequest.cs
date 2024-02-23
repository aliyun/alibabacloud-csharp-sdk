// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryVoiceFileAuditInfoRequest : TeaModel {
        /// <summary>
        /// The type of the voice file. Valid values:
        /// 
        /// *   **0** (default): the voice notification file.
        /// *   **2**: the recording file.
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public int? BusinessType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the voice file. You can log on to the [Voice Messaging Service console](https://dyvms.console.aliyun.com/overview/home), choose **Voice Messages** > **Voice Notifications** or **Voice File Management**, and then click the **Voice Notification Files** tab to view the **voice ID**.
        /// 
        /// > You can query up to 10 voice files each time. Separate the voice file names with commas (,).
        /// </summary>
        [NameInMap("VoiceCodes")]
        [Validation(Required=false)]
        public string VoiceCodes { get; set; }

    }

}
