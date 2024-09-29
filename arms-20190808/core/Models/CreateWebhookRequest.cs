// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateWebhookRequest : TeaModel {
        /// <summary>
        /// <para>The notification template that is sent when an alert is triggered. This parameter is required if the <b>Method</b> parameter is set to <b>Post</b>. You can use the $content placeholder to specify the notification content. The content cannot exceed 500 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;Alert Name&quot;: &quot;{{ .commonLabels.alertname }}{{if .commonLabels.clustername }}&quot;, &quot;Cluster Name&quot;: &quot;{{ .commonLabels.clustername }} {{ end }}{{if eq &quot; app&quot; .commonLabels._aliyun_arms_involvedObject_kind }}&quot;, &quot;Application Name&quot;: &quot;{{ .commonLabels._aliyun_arms_involvedObject_name }} {{ end }}&quot;, &quot;Notification Policy&quot;: &quot;{{ .dispatchRuleName }}&quot;, &quot;Alarm Time&quot;: &quot;{{ .startTime }}&quot;, &quot;Alert Content&quot;: &quot;{{ for .alerts }} {{ .annotations.message }} {{ end }}&quot; }</para>
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>The name of the contact.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WebhookAlert</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>The HTTP request header.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Content-Type&quot;:&quot;application/json&quot;}]</para>
        /// </summary>
        [NameInMap("HttpHeaders")]
        [Validation(Required=false)]
        public string HttpHeaders { get; set; }

        /// <summary>
        /// <para>The parameters in the HTTP request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;mike&quot;}]</para>
        /// </summary>
        [NameInMap("HttpParams")]
        [Validation(Required=false)]
        public string HttpParams { get; set; }

        /// <summary>
        /// <para>The HTTP request method.</para>
        /// <list type="bullet">
        /// <item><description><c>Get</c></description></item>
        /// <item><description><c>Post</c></description></item>
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
        /// <para>The notification template that is sent when an alert is resolved. This parameter is required if the <b>Method</b> parameter is set to <b>Post</b>. You can use the $content placeholder to specify the notification content. The content cannot exceed 500 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;Alert Name&quot;: &quot;{{ .commonLabels.alertname }}{{if .commonLabels.clustername }}&quot;, &quot;Cluster Name&quot;: &quot;{{ .commonLabels.clustername }} {{ end }}{{if eq &quot; app&quot; .commonLabels._aliyun_arms_involvedObject_kind }}&quot;, &quot;Application Name&quot;: &quot;{{ .commonLabels._aliyun_arms_involvedObject_name }} {{ end }}&quot;, &quot;Notification Policy&quot;: &quot;{{ .dispatchRuleName }}&quot;, &quot;Alarm Time&quot;: &quot;{{ .startTime }}&quot;, &quot;Alert Content&quot;: &quot;{{ for .alerts }} {{ .annotations.message }} {{ end }}&quot; }</para>
        /// </summary>
        [NameInMap("RecoverBody")]
        [Validation(Required=false)]
        public string RecoverBody { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The URL of the request <b>method</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=e1a049121ddbfce1ca963d115ef88cc7219583c4fb79fe6e398fbfb688">https://oapi.dingtalk.com/robot/send?access_token=e1a049121ddbfce1ca963d115ef88cc7219583c4fb79fe6e398fbfb688</a>******</para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
