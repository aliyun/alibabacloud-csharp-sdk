// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListPrometheusAlertRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request was successful. Other status codes indicate that the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The returned struct.</para>
        /// </summary>
        [NameInMap("PrometheusAlertRules")]
        [Validation(Required=false)]
        public List<ListPrometheusAlertRulesResponseBodyPrometheusAlertRules> PrometheusAlertRules { get; set; }
        public class ListPrometheusAlertRulesResponseBodyPrometheusAlertRules : TeaModel {
            /// <summary>
            /// <para>The ID of the alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3888704</para>
            /// </summary>
            [NameInMap("AlertId")]
            [Validation(Required=false)]
            public long? AlertId { get; set; }

            /// <summary>
            /// <para>The name of the alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Prometheus_Alert</para>
            /// </summary>
            [NameInMap("AlertName")]
            [Validation(Required=false)]
            public string AlertName { get; set; }

            /// <summary>
            /// <para>The annotations of the alert rule.</para>
            /// </summary>
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<ListPrometheusAlertRulesResponseBodyPrometheusAlertRulesAnnotations> Annotations { get; set; }
            public class ListPrometheusAlertRulesResponseBodyPrometheusAlertRulesAnnotations : TeaModel {
                /// <summary>
                /// <para>The name of the annotation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>message</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the annotation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The CPU utilization of ${{$labels.pod_name}} exceeds 80%. Current value: {{$value}}%</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c0bad479465464e1d8c1e641b0afb****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The ID of the notification policy. This parameter is returned if the NotifyType parameter is set to <c>DISPATCH_RULE</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10282</para>
            /// </summary>
            [NameInMap("DispatchRuleId")]
            [Validation(Required=false)]
            public long? DispatchRuleId { get; set; }

            /// <summary>
            /// <para>The duration of the alert. Valid values: 1 to 1440. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1m</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>The expression of the alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100 * (sum(rate(container_cpu_usage_seconds_total[1m])) by (pod_name) / sum(label_replace(kube_pod_container_resource_limits_cpu_cores, \&quot;pod_name\&quot;, \&quot;$1\&quot;, \&quot;pod\&quot;, \&quot;(.*)\&quot;)) by (pod_name))&gt;75</para>
            /// </summary>
            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            /// <summary>
            /// <para>The tags of the alert rule.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListPrometheusAlertRulesResponseBodyPrometheusAlertRulesLabels> Labels { get; set; }
            public class ListPrometheusAlertRulesResponseBodyPrometheusAlertRulesLabels : TeaModel {
                /// <summary>
                /// <para>The name of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>severity</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the tag associated with the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>critical</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The alert message. Tags can be referenced in the {{$labels.xxx}} format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The CPU utilization of ${{$labels.pod_name}} exceeds 80%. Current value: {{$value}}%</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The method that is used to send alert notifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALERT_MANAGER: Alert notifications are sent by Operation Center.</description></item>
            /// <item><description>DISPATCH_RULE: Alert notifications are</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALERT_MANAGER</para>
            /// </summary>
            [NameInMap("NotifyType")]
            [Validation(Required=false)]
            public string NotifyType { get; set; }

            /// <summary>
            /// <para>Indicates whether the alert rule is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: The alert rule is enabled.</description></item>
            /// <item><description>0: The alert rule is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListPrometheusAlertRulesResponseBodyPrometheusAlertRulesTags> Tags { get; set; }
            public class ListPrometheusAlertRulesResponseBodyPrometheusAlertRulesTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The type of the alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9FEA6D00-317F-45E3-9004-7FB8B0B7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
