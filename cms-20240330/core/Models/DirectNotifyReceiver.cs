// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DirectNotifyReceiver : TeaModel {
        /// <summary>
        /// <para>The list of notification channels. This parameter is valid only for person types (CONTACT/GROUP/DUTY). Valid values: SMS, CALL, EMAIL.</para>
        /// </summary>
        [NameInMap("channels")]
        [Validation(Required=false)]
        public List<string> Channels { get; set; }

        /// <summary>
        /// <para>The list of notification recipient identifiers. For person types, this is the identifier of the contact, contact group, or on-call schedule. For IM types, this is the webhook identifier.</para>
        /// </summary>
        [NameInMap("identifiers")]
        [Validation(Required=false)]
        public List<string> Identifiers { get; set; }

        /// <summary>
        /// <para>The Notification Recipient type. For person types (CONTACT/GROUP/DUTY), you must specify notification channels by using the channels parameter. For IM types (DINGTALK/FEISHU/SLACK/WEIXIN/WEBHOOK), the channels parameter is not required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONTACT</para>
        /// </summary>
        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
