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
        /// <para>The list of custom webhook notification recipient IDs.</para>
        /// </summary>
        [NameInMap("customWebhooks")]
        [Validation(Required=false)]
        public List<string> CustomWebhooks { get; set; }

        /// <summary>
        /// <para>The list of DingTalk cool app webhook notification recipient IDs.</para>
        /// </summary>
        [NameInMap("dingCoolAppWebhooks")]
        [Validation(Required=false)]
        public List<string> DingCoolAppWebhooks { get; set; }

        /// <summary>
        /// <para>The list of DingTalk webhook notification recipient IDs.</para>
        /// </summary>
        [NameInMap("dingWebhooks")]
        [Validation(Required=false)]
        public List<string> DingWebhooks { get; set; }

        /// <summary>
        /// <para>The list of Lark webhook notification recipient IDs.</para>
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
        /// <para>The notification time period during which notifications are sent.</para>
        /// </summary>
        [NameInMap("notifyTime")]
        [Validation(Required=false)]
        public AlertRuleTimeSpan NotifyTime { get; set; }

        /// <summary>
        /// <para>The Qwen notification recipient configuration. The outer and inner keys are custom identifiers, and the inner Boolean value specifies whether to enable the notification recipient.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;teamA&quot;:{&quot;oncall&quot;:true}}</para>
        /// </summary>
        [NameInMap("qwencloudContacts")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> QwencloudContacts { get; set; }

        /// <summary>
        /// <para>Specifies whether to send a recovery notification. This setting can be independently overridden for each severity level in severityNotifications.</para>
        /// </summary>
        [NameInMap("sendOk")]
        [Validation(Required=false)]
        public bool? SendOk { get; set; }

        /// <summary>
        /// <para>The notification recipients and channels configured by severity level, which are mutually exclusive with top-level contacts and groups. The key is the severity level: CRITICAL, ERROR, WARNING, or INFO.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CRITICAL&quot;:{&quot;sendRecoverNotification&quot;:true}}</para>
        /// </summary>
        [NameInMap("severityNotifications")]
        [Validation(Required=false)]
        public Dictionary<string, SeverityNotifyConfig> SeverityNotifications { get; set; }

        /// <summary>
        /// <para>The notification mute period, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("silenceTime")]
        [Validation(Required=false)]
        public long? SilenceTime { get; set; }

        /// <summary>
        /// <para>The list of Slack webhook notification recipient IDs.</para>
        /// </summary>
        [NameInMap("slackWebhooks")]
        [Validation(Required=false)]
        public List<string> SlackWebhooks { get; set; }

        /// <summary>
        /// <para>The list of WeChat webhook notification recipient IDs.</para>
        /// </summary>
        [NameInMap("wxWebhooks")]
        [Validation(Required=false)]
        public List<string> WxWebhooks { get; set; }

    }

}
