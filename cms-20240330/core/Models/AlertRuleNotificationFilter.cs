// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleNotificationFilter : TeaModel {
        /// <summary>
        /// <para>A list of contact IDs for filtering.</para>
        /// </summary>
        [NameInMap("contacts")]
        [Validation(Required=false)]
        public List<string> Contacts { get; set; }

        /// <summary>
        /// <para>A list of custom webhook IDs for filtering.</para>
        /// </summary>
        [NameInMap("customWebhooks")]
        [Validation(Required=false)]
        public List<string> CustomWebhooks { get; set; }

        /// <summary>
        /// <para>A list of DingTalk webhook IDs for filtering.</para>
        /// </summary>
        [NameInMap("dingWebhooks")]
        [Validation(Required=false)]
        public List<string> DingWebhooks { get; set; }

        /// <summary>
        /// <para>A list of Lark webhook IDs for filtering.</para>
        /// </summary>
        [NameInMap("fsWebhooks")]
        [Validation(Required=false)]
        public List<string> FsWebhooks { get; set; }

        /// <summary>
        /// <para>A list of contact group IDs for filtering.</para>
        /// </summary>
        [NameInMap("groups")]
        [Validation(Required=false)]
        public List<string> Groups { get; set; }

        /// <summary>
        /// <para>A list of Slack webhook IDs for filtering.</para>
        /// </summary>
        [NameInMap("slackWebhooks")]
        [Validation(Required=false)]
        public List<string> SlackWebhooks { get; set; }

        /// <summary>
        /// <para>A list of WeChat webhook IDs for filtering.</para>
        /// </summary>
        [NameInMap("wxWebhooks")]
        [Validation(Required=false)]
        public List<string> WxWebhooks { get; set; }

    }

}
