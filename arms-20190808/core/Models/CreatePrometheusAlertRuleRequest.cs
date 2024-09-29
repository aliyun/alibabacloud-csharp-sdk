// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreatePrometheusAlertRuleRequest : TeaModel {
        /// <summary>
        /// <para>The name of the alert rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Prometheus_Alert</para>
        /// </summary>
        [NameInMap("AlertName")]
        [Validation(Required=false)]
        public string AlertName { get; set; }

        /// <summary>
        /// <para>The annotations that are described in a JSON string. You must specify the name and value of each annotation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Value&quot;: &quot;xxx&quot;,&quot;Name&quot;: &quot;description&quot;}]</para>
        /// </summary>
        [NameInMap("Annotations")]
        [Validation(Required=false)]
        public string Annotations { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c0bad479465464e1d8c1e641b0afb****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the notification policy. This parameter is required if the NotifyType parameter is set to <c>DISPATCH_RULE</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10282</para>
        /// </summary>
        [NameInMap("DispatchRuleId")]
        [Validation(Required=false)]
        public long? DispatchRuleId { get; set; }

        /// <summary>
        /// <para>The duration. The value ranges from 1 to 1440 minutes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10m</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The expression of the alert rule. The expression must follow the PromQL syntax.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100 * (sum(rate(container_cpu_usage_seconds_total[1m])) by (pod_name) / sum(label_replace(kube_pod_container_resource_limits_cpu_cores, \&quot;pod_name\&quot;, \&quot;$1\&quot;, \&quot;pod\&quot;, \&quot;(.*)\&quot;)) by (pod_name))&gt;75</para>
        /// </summary>
        [NameInMap("Expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// <para>The tags that are described in a JSON string. You must specify the name and value of each tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Value&quot;: &quot;critical&quot;,&quot;Name&quot;: &quot;severity&quot;}]</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>The content of the alert notification. Tags can be referenced in the {{$labels.xxx}} format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The CPU utilization of ${{$labels.pod_name}} has exceeded 80%. Current value: {{$value}}%</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The method that is used to send alert notifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ALERT_MANAGER</c>: Alert notifications are sent by Operation Center. This is the default value.</description></item>
        /// <item><description><c>DISPATCH_RULE</c>: Alert notifications are sent based on the specified notification policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALERT_MANAGER</para>
        /// </summary>
        [NameInMap("NotifyType")]
        [Validation(Required=false)]
        public string NotifyType { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreatePrometheusAlertRuleRequestTags> Tags { get; set; }
        public class CreatePrometheusAlertRuleRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>type</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type of the alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>99: custom alert</description></item>
        /// <item><description>101: Prometheus Service alert</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
