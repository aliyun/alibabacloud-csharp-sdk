// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeWebhookContactsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned objects.</para>
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public DescribeWebhookContactsResponseBodyPageBean PageBean { get; set; }
        public class DescribeWebhookContactsResponseBodyPageBean : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// <para>The number of alert contacts displayed on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The total number of alert contacts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

            /// <summary>
            /// <para>The list of webhook alert contacts.</para>
            /// </summary>
            [NameInMap("WebhookContacts")]
            [Validation(Required=false)]
            public List<DescribeWebhookContactsResponseBodyPageBeanWebhookContacts> WebhookContacts { get; set; }
            public class DescribeWebhookContactsResponseBodyPageBeanWebhookContacts : TeaModel {
                /// <summary>
                /// <para>The details of the webhook alert contact.</para>
                /// </summary>
                [NameInMap("Webhook")]
                [Validation(Required=false)]
                public DescribeWebhookContactsResponseBodyPageBeanWebhookContactsWebhook Webhook { get; set; }
                public class DescribeWebhookContactsResponseBodyPageBeanWebhookContactsWebhook : TeaModel {
                    /// <summary>
                    /// <para>The header of the HTTP request.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[{&quot;Content-Type&quot;:&quot;application/json&quot;}]</para>
                    /// </summary>
                    [NameInMap("BizHeaders")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> BizHeaders { get; set; }

                    /// <summary>
                    /// <para>The parameters in the HTTP request.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[{&quot;content:&quot;mike&quot;}]</para>
                    /// </summary>
                    [NameInMap("BizParams")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> BizParams { get; set; }

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
                    /// <item><description>Get</description></item>
                    /// <item><description>Post</description></item>
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
                    /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=91f2f6">https://oapi.dingtalk.com/robot/send?access_token=91f2f6</a>****</para>
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
                /// <para>Webhook name</para>
                /// </summary>
                [NameInMap("WebhookName")]
                [Validation(Required=false)]
                public string WebhookName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4D6C358A-A58B-4F4B-94CE-F5AAF023****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
