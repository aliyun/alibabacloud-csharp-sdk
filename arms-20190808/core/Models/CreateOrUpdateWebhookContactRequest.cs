// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateWebhookContactRequest : TeaModel {
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
        /// <para>The notification template that is sent when an alert is triggered. This parameter is required if the <b>Method</b> parameter is set to <b>Post</b>. You can use the <c>$content</c> placeholder to specify the notification content. The content cannot exceed 500 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/251834.html">Variable description of a notification template</a>.\\</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Post</para>
        /// </summary>
        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        /// <summary>
        /// <para>The notification template that is sent when an alert is resolved. This parameter is required if the <b>Method</b> parameter is set to <b>Post</b>. You can use the <c>$content</c> placeholder to specify the notification content. The content cannot exceed 500 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/251834.html">Variable description of a notification template</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;Alert name&quot;:&quot;{{ .commonLabels.alertname }}{{if .commonLabels.clustername }}&quot;, &quot;Cluster name&quot;:&quot;{{ .commonLabels.clustername }} {{ end }}{{if eq &quot;app&quot; .commonLabels._aliyun_arms_involvedObject_kind }}&quot;, &quot;Application name&quot;:&quot;{{ .commonLabels._aliyun_arms_involvedObject_name }} {{ end }}&quot;, &quot;Notification policy&quot;:&quot;{{ .dispatchRuleName }}&quot;, &quot;Recovery time&quot;:&quot;{{ .endTime }}&quot;, &quot;Alert content&quot;:&quot;{{ for .alerts }} {{ .annotations.message }} {{ end }}&quot; }</para>
        /// </summary>
        [NameInMap("RecoverBody")]
        [Validation(Required=false)]
        public string RecoverBody { get; set; }

        /// <summary>
        /// <para>The URL of the HTTP request <b>method</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=e1a049121">https://oapi.dingtalk.com/robot/send?access_token=e1a049121</a>******</para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// <para>The ID of the webhook alert contact.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, a new webhook alert contact is created.</description></item>
        /// <item><description>If you specify this parameter, the specified webhook alert contact is modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("WebhookId")]
        [Validation(Required=false)]
        public long? WebhookId { get; set; }

        /// <summary>
        /// <para>The name of the webhook alert contact.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Webhook alert</para>
        /// </summary>
        [NameInMap("WebhookName")]
        [Validation(Required=false)]
        public string WebhookName { get; set; }

    }

}
