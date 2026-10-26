// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotificationChannelsFilter : TeaModel {
        /// <summary>
        /// <para>The list of notification contacts in the rule contains any value in the array. This uses OR logic and corresponds to notification.contacts in V1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;张三&quot;,&quot;李四&quot;]</para>
        /// </summary>
        [NameInMap("containsContacts")]
        [Validation(Required=false)]
        public List<string> ContainsContacts { get; set; }

        /// <summary>
        /// <para>The list of custom webhooks in the rule contains any value in the array. This uses OR logic and corresponds to notification.customWebhooks in V1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<a href="https://my-service.example.com/webhook/alert%22%5D">https://my-service.example.com/webhook/alert&quot;]</a></para>
        /// </summary>
        [NameInMap("containsCustomWebhooks")]
        [Validation(Required=false)]
        public List<string> ContainsCustomWebhooks { get; set; }

        /// <summary>
        /// <para>The list of DingTalk webhooks in the rule contains any value in the array. This uses OR logic and corresponds to notification.dingWebhooks in V1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<a href="https://oapi.dingtalk.com/robot/send?access_token=abc123%22%5D">https://oapi.dingtalk.com/robot/send?access_token=abc123&quot;]</a></para>
        /// </summary>
        [NameInMap("containsDingWebhooks")]
        [Validation(Required=false)]
        public List<string> ContainsDingWebhooks { get; set; }

        /// <summary>
        /// <para>The list of Lark webhooks in the rule contains any value in the array. This uses OR logic and corresponds to notification.fsWebhooks in V1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<a href="https://open.feishu.cn/open-apis/bot/v2/hook/abc123%22%5D">https://open.feishu.cn/open-apis/bot/v2/hook/abc123&quot;]</a></para>
        /// </summary>
        [NameInMap("containsFsWebhooks")]
        [Validation(Required=false)]
        public List<string> ContainsFsWebhooks { get; set; }

        /// <summary>
        /// <para>The list of contact groups in the rule contains any value in the array. This uses OR logic and corresponds to notification.groups in V1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;运维组&quot;,&quot;SRE团队&quot;]</para>
        /// </summary>
        [NameInMap("containsGroups")]
        [Validation(Required=false)]
        public List<string> ContainsGroups { get; set; }

        /// <summary>
        /// <para>The list of Slack webhooks in the rule contains any value in the array. This uses OR logic and corresponds to notification.slackWebhooks in V1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<a href="https://hooks.slack.com/services/T00000000/B00000000/XXXXXXXX%22%5D">https://hooks.slack.com/services/T00000000/B00000000/XXXXXXXX&quot;]</a></para>
        /// </summary>
        [NameInMap("containsSlackWebhooks")]
        [Validation(Required=false)]
        public List<string> ContainsSlackWebhooks { get; set; }

        /// <summary>
        /// <para>The list of WeCom webhooks in the rule contains any value in the array. This uses OR logic and corresponds to notification.wxWebhooks in V1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<a href="https://qyapi.weixin.qq.com/cgi-bin/webhook/send?key=abc123%22%5D">https://qyapi.weixin.qq.com/cgi-bin/webhook/send?key=abc123&quot;]</a></para>
        /// </summary>
        [NameInMap("containsWxWebhooks")]
        [Validation(Required=false)]
        public List<string> ContainsWxWebhooks { get; set; }

    }

}
