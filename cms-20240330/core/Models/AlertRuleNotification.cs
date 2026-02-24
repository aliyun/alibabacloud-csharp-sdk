// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleNotification : TeaModel {
        /// <summary>
        /// <para>List of contact IDs.</para>
        /// </summary>
        [NameInMap("contacts")]
        [Validation(Required=false)]
        public List<string> Contacts { get; set; }

        /// <summary>
        /// <para>List of custom webhook notification object IDs.</para>
        /// </summary>
        [NameInMap("customWebhooks")]
        [Validation(Required=false)]
        public List<string> CustomWebhooks { get; set; }

        [NameInMap("dingCoolAppWebhooks")]
        [Validation(Required=false)]
        public List<string> DingCoolAppWebhooks { get; set; }

        /// <summary>
        /// <para>List of DingTalk webhook notification object IDs.</para>
        /// </summary>
        [NameInMap("dingWebhooks")]
        [Validation(Required=false)]
        public List<string> DingWebhooks { get; set; }

        /// <summary>
        /// <para>List of Feishu webhook notification object IDs.</para>
        /// </summary>
        [NameInMap("fsWebhooks")]
        [Validation(Required=false)]
        public List<string> FsWebhooks { get; set; }

        /// <summary>
        /// <para>List of contact group IDs.</para>
        /// </summary>
        [NameInMap("groups")]
        [Validation(Required=false)]
        public List<string> Groups { get; set; }

        /// <summary>
        /// <para>Notification time window; notifications are sent only during this period.</para>
        /// </summary>
        [NameInMap("notifyTime")]
        [Validation(Required=false)]
        public AlertRuleTimeSpan NotifyTime { get; set; }

        /// <summary>
        /// <para>Notification silence duration, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("silenceTime")]
        [Validation(Required=false)]
        public long? SilenceTime { get; set; }

        /// <summary>
        /// <para>List of Slack webhook notification object IDs.</para>
        /// </summary>
        [NameInMap("slackWebhooks")]
        [Validation(Required=false)]
        public List<string> SlackWebhooks { get; set; }

        /// <summary>
        /// <para>List of WeChat webhook notification object IDs.</para>
        /// </summary>
        [NameInMap("wxWebhooks")]
        [Validation(Required=false)]
        public List<string> WxWebhooks { get; set; }

    }

}
