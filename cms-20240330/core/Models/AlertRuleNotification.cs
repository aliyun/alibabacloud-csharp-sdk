// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleNotification : TeaModel {
        /// <summary>
        /// <para>The list of contact IDs.</para>
        /// </summary>
        [NameInMap("contacts")]
        [Validation(Required=false)]
        public List<string> Contacts { get; set; }

        /// <summary>
        /// <para>The list of custom webhook Notification Recipient IDs.</para>
        /// </summary>
        [NameInMap("customWebhooks")]
        [Validation(Required=false)]
        public List<string> CustomWebhooks { get; set; }

        /// <summary>
        /// <para>The list of DingTalk Cool App webhook Notification Recipient IDs.</para>
        /// </summary>
        [NameInMap("dingCoolAppWebhooks")]
        [Validation(Required=false)]
        public List<string> DingCoolAppWebhooks { get; set; }

        /// <summary>
        /// <para>The list of DingTalk webhook Notification Recipient IDs.</para>
        /// </summary>
        [NameInMap("dingWebhooks")]
        [Validation(Required=false)]
        public List<string> DingWebhooks { get; set; }

        /// <summary>
        /// <para>The list of Lark webhook Notification Recipient IDs.</para>
        /// </summary>
        [NameInMap("fsWebhooks")]
        [Validation(Required=false)]
        public List<string> FsWebhooks { get; set; }

        /// <summary>
        /// <para>The list of contact group IDs.</para>
        /// </summary>
        [NameInMap("groups")]
        [Validation(Required=false)]
        public List<string> Groups { get; set; }

        /// <summary>
        /// <para>The notification time period. Notifications are sent only during this time period.</para>
        /// </summary>
        [NameInMap("notifyTime")]
        [Validation(Required=false)]
        public AlertRuleTimeSpan NotifyTime { get; set; }

        [NameInMap("qwencloudContacts")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> QwencloudContacts { get; set; }

        [NameInMap("sendOk")]
        [Validation(Required=false)]
        public bool? SendOk { get; set; }

        [NameInMap("severityNotifications")]
        [Validation(Required=false)]
        public Dictionary<string, SeverityNotifyConfig> SeverityNotifications { get; set; }

        /// <summary>
        /// <para>The notification mute duration, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("silenceTime")]
        [Validation(Required=false)]
        public long? SilenceTime { get; set; }

        /// <summary>
        /// <para>The list of Slack webhook Notification Recipient IDs.</para>
        /// </summary>
        [NameInMap("slackWebhooks")]
        [Validation(Required=false)]
        public List<string> SlackWebhooks { get; set; }

        /// <summary>
        /// <para>The list of WeChat webhook Notification Recipient IDs.</para>
        /// </summary>
        [NameInMap("wxWebhooks")]
        [Validation(Required=false)]
        public List<string> WxWebhooks { get; set; }

    }

}
