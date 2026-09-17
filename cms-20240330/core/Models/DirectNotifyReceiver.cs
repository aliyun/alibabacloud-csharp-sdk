// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DirectNotifyReceiver : TeaModel {
        /// <summary>
        /// <para>The list of notification methods. This parameter is valid only for personnel types (CONTACT/GROUP/DUTY). Valid values: SMS, CALL, EMAIL.</para>
        /// </summary>
        [NameInMap("channels")]
        [Validation(Required=false)]
        public List<string> Channels { get; set; }

        /// <summary>
        /// <para>The list of Notification Recipient identifiers. For personnel types, this is the identifier of a contact, contact group, or on-call schedule. For IM types, this is the webhook identifier.</para>
        /// </summary>
        [NameInMap("identifiers")]
        [Validation(Required=false)]
        public List<string> Identifiers { get; set; }

        /// <summary>
        /// <para>The Notification Recipient object type. Personnel types (CONTACT/GROUP/DUTY) require the channels parameter to specify notification methods. IM types (DINGTALK/FEISHU/SLACK/WEIXIN/WEBHOOK) do not require the channels parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONTACT</para>
        /// </summary>
        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
