// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteDingTalkRequest : TeaModel {
        /// <summary>
        /// The ID of the notification from the DingTalk chatbot. Separate multiple IDs with commas (,).
        /// 
        /// >  You can call the [DescribeDingTalk](~~DescribeDingTalk~~) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

    }

}
