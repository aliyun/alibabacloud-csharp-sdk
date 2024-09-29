// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateWebhookContactResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16AF921B-8187-489F-9913-43C808B4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned webhook alert contact.</para>
        /// </summary>
        [NameInMap("WebhookContact")]
        [Validation(Required=false)]
        public CreateOrUpdateWebhookContactResponseBodyWebhookContact WebhookContact { get; set; }
        public class CreateOrUpdateWebhookContactResponseBodyWebhookContact : TeaModel {
            /// <summary>
            /// <para>The information about the webhook alert contact.</para>
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public CreateOrUpdateWebhookContactResponseBodyWebhookContactWebhook Webhook { get; set; }
            public class CreateOrUpdateWebhookContactResponseBodyWebhookContactWebhook : TeaModel {
                /// <summary>
                /// <para>The HTTP request headers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;Content-Type&quot;:&quot;application/json;charset=utf-8&quot;}]</para>
                /// </summary>
                [NameInMap("BizHeaders")]
                [Validation(Required=false)]
                public string BizHeaders { get; set; }

                /// <summary>
                /// <para>The parameters in the HTTP request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;content&quot;:&quot;mike&quot;}]</para>
                /// </summary>
                [NameInMap("BizParams")]
                [Validation(Required=false)]
                public string BizParams { get; set; }

                /// <summary>
                /// <para>The alert notification template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;Alert name&quot;:&quot;{{ .commonLabels.alertname }}{{if .commonLabels.clustername }}&quot;, &quot;Cluster name&quot;:&quot;{{ .commonLabels.clustername }} {{ end }}{{if eq &quot;app&quot; .commonLabels._aliyun_arms_involvedObject_kind }}&quot;, &quot;Application name&quot;:&quot;{{ .commonLabels._aliyun_arms_involvedObject_name }} {{ end }}&quot;, &quot;Notification policy&quot;:&quot;{{ .dispatchRuleName }}&quot;, &quot;Alert time&quot;:&quot;{{ .startTime }}&quot;, &quot;Alert content&quot;:&quot;{{ for .alerts }} {{ .annotations.message }} {{ end }}&quot; }</para>
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public string Body { get; set; }

                /// <summary>
                /// <para>The HTTP request method.</para>
                /// <list type="bullet">
                /// <item><description>Post</description></item>
                /// <item><description>Get</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Post</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The notification template for clearing alerts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;Alert name&quot;:&quot;{{ .commonLabels.alertname }}{{if .commonLabels.clustername }}&quot;, &quot;Cluster name&quot;:&quot;{{ .commonLabels.clustername }} {{ end }}{{if eq &quot;app&quot; .commonLabels._aliyun_arms_involvedObject_kind }}&quot;, &quot;Application name&quot;:&quot;{{ .commonLabels._aliyun_arms_involvedObject_name }} {{ end }}&quot;, &quot;Notification policy&quot;:&quot;{{ .dispatchRuleName }}&quot;, &quot;Recovery time&quot;:&quot;{{ .endTime }}&quot;, &quot;Alert content&quot;:&quot;{{ for .alerts }} {{ .annotations.message }} {{ end }}&quot; }</para>
                /// </summary>
                [NameInMap("RecoverBody")]
                [Validation(Required=false)]
                public string RecoverBody { get; set; }

                /// <summary>
                /// <para>The URL of the request method.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=e1a049121">https://oapi.dingtalk.com/robot/send?access_token=e1a049121</a>******</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The ID of the webhook alert contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("WebhookId")]
            [Validation(Required=false)]
            public float? WebhookId { get; set; }

            /// <summary>
            /// <para>The name of the webhook alert contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Webhook alert</para>
            /// </summary>
            [NameInMap("WebhookName")]
            [Validation(Required=false)]
            public string WebhookName { get; set; }

        }

    }

}
