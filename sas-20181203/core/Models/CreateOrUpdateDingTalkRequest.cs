// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateOrUpdateDingTalkRequest : TeaModel {
        /// <summary>
        /// The alerts for which you want the chatbot to send notifications. The value is a JSON array that contains the following fields:
        /// 
        /// *   **type**: the types of alerts. The valid values are listed in the "Additional description of parameters" section in this topic.
        /// 
        /// *   **configItemList**: the list of check items. The value is a JSON array that contains the following fields:
        /// 
        ///     *   **key**: the key of the check item.
        ///     *   **valueList**: the values of the check item. The value of valueList is a JSON array.
        /// 
        /// > For more information about the value of this parameter, see the "Addition description of parameters" section in this topic.
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public string ConfigList { get; set; }

        /// <summary>
        /// The language of the notifications. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("DingTalkLang")]
        [Validation(Required=false)]
        public string DingTalkLang { get; set; }

        /// <summary>
        /// The IDs of asset groups for which you want the chatbot to send notifications. The value is a JSON array.
        /// 
        /// > You can call the [DescribeGroupStruct](~~DescribeGroupStruct~~) operation to query the IDs of asset groups.
        /// </summary>
        [NameInMap("GroupIdList")]
        [Validation(Required=false)]
        public string GroupIdList { get; set; }

        /// <summary>
        /// The ID of the chatbot.
        /// 
        /// > You can call the [DescribeDingTalk](https://www.alibabacloud.com/help/en/security-center/developer-reference/api-sas-2018-12-03-describedingtalk/?spm=a2c63.p38356.0.0.681e4360Qd1eb1) operation to query the IDs of chatbots.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The time interval at which the chatbot sends notifications.
        /// 
        /// > The value **0** indicates unlimited.
        /// </summary>
        [NameInMap("IntervalTime")]
        [Validation(Required=false)]
        public long? IntervalTime { get; set; }

        /// <summary>
        /// The name of the chatbot.
        /// 
        /// > The name of a chatbot must be 2 to 64 characters in length.
        /// </summary>
        [NameInMap("RuleActionName")]
        [Validation(Required=false)]
        public string RuleActionName { get; set; }

        /// <summary>
        /// The webhook URL.
        /// </summary>
        [NameInMap("SendUrl")]
        [Validation(Required=false)]
        public string SendUrl { get; set; }

    }

}
