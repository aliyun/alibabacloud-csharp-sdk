// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotificationChannelsFilter : TeaModel {
        /// <summary>
        /// <para>The alert contact list of the rule contains any value in the array (OR semantics), corresponding to V1 notification.contacts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;John&quot;,&quot;Jane&quot;]</para>
        /// </summary>
        [NameInMap("containsContacts")]
        [Validation(Required=false)]
        public List<string> ContainsContacts { get; set; }

        /// <summary>
        /// <para>The custom webhook list of the rule contains any value in the array (OR semantics), corresponding to V1 notification.customWebhooks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<a href="https://my-service.example.com/webhook/alert%22%5D">https://my-service.example.com/webhook/alert&quot;]</a></para>
        /// </summary>
        [NameInMap("containsCustomWebhooks")]
        [Validation(Required=false)]
        public List<string> ContainsCustomWebhooks { get; set; }

        /// <summary>
        /// <para>The DingTalk webhook list of the rule contains any value in the array (OR semantics), corresponding to V1 notification.dingWebhooks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<a href="https://oapi.dingtalk.com/robot/send?access_token=abc123%22%5D">https://oapi.dingtalk.com/robot/send?access_token=abc123&quot;]</a></para>
        /// </summary>
        [NameInMap("containsDingWebhooks")]
        [Validation(Required=false)]
        public List<string> ContainsDingWebhooks { get; set; }

        /// <summary>
        /// <para>The Lark webhook list of the rule contains any value in the array (OR semantics), corresponding to V1 notification.fsWebhooks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<a href="https://open.feishu.cn/open-apis/bot/v2/hook/abc123%22%5D">https://open.feishu.cn/open-apis/bot/v2/hook/abc123&quot;]</a></para>
        /// </summary>
        [NameInMap("containsFsWebhooks")]
        [Validation(Required=false)]
        public List<string> ContainsFsWebhooks { get; set; }

        /// <summary>
        /// <para>The alert contact group list of the rule contains any value in the array (OR semantics), corresponding to V1 notification.groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;OpsTeam&quot;,&quot;SRETeam&quot;]</para>
        /// </summary>
        [NameInMap("containsGroups")]
        [Validation(Required=false)]
        public List<string> ContainsGroups { get; set; }

        /// <summary>
        /// <para>The Slack webhook list of the rule contains any value in the array (OR semantics), corresponding to V1 notification.slackWebhooks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<a href="https://hooks.slack.com/services/T00000000/B00000000/XXXXXXXX%22%5D">https://hooks.slack.com/services/T00000000/B00000000/XXXXXXXX&quot;]</a></para>
        /// </summary>
        [NameInMap("containsSlackWebhooks")]
        [Validation(Required=false)]
        public List<string> ContainsSlackWebhooks { get; set; }

        /// <summary>
        /// <para>The WeCom webhook list of the rule contains any value in the array (OR semantics), corresponding to V1 notification.wxWebhooks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<a href="https://qyapi.weixin.qq.com/cgi-bin/webhook/send?key=abc123%22%5D">https://qyapi.weixin.qq.com/cgi-bin/webhook/send?key=abc123&quot;]</a></para>
        /// </summary>
        [NameInMap("containsWxWebhooks")]
        [Validation(Required=false)]
        public List<string> ContainsWxWebhooks { get; set; }

    }

}
