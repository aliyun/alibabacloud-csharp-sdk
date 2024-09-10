// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyDingTalkStatusRequest : TeaModel {
        /// <summary>
        /// The notification IDs of DingTalk chatbots. Separate multiple IDs with commas (,).
        /// 
        /// >  You can call the [DescribeDingTalk](~~DescribeDingTalk~~) operation to query the notification IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// The notification status of a DingTalk chatbot. Valid values:
        /// 
        /// *   **0**: disabled
        /// *   **1**: enabled
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
