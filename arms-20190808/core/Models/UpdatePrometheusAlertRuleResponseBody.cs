// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdatePrometheusAlertRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. The status code 200 indicates that the request was successful.</para>
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
        [NameInMap("PrometheusAlertRule")]
        [Validation(Required=false)]
        public UpdatePrometheusAlertRuleResponseBodyPrometheusAlertRule PrometheusAlertRule { get; set; }
        public class UpdatePrometheusAlertRuleResponseBodyPrometheusAlertRule : TeaModel {
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
            /// <para>The annotation of the alert rule.</para>
            /// </summary>
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<UpdatePrometheusAlertRuleResponseBodyPrometheusAlertRuleAnnotations> Annotations { get; set; }
            public class UpdatePrometheusAlertRuleResponseBodyPrometheusAlertRuleAnnotations : TeaModel {
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
                /// <para>${{$labels.pod_name}}CPU使用率大于80%，当前值{{$value}}%</para>
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
            /// <para>The ID of the notification policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10282</para>
            /// </summary>
            [NameInMap("DispatchRuleId")]
            [Validation(Required=false)]
            public long? DispatchRuleId { get; set; }

            /// <summary>
            /// <para>The duration. The value ranges from 1 to 1440 minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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
            public List<UpdatePrometheusAlertRuleResponseBodyPrometheusAlertRuleLabels> Labels { get; set; }
            public class UpdatePrometheusAlertRuleResponseBodyPrometheusAlertRuleLabels : TeaModel {
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
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>critical</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The returned message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>${{$labels.pod_name}}CPU使用率大于80%，当前值{{$value}}%</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The method of that is used to send alert notifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>ALERT_MANAGER</c>: Alert notifications are sent by Operation Center.</para>
            /// </description></item>
            /// <item><description><para><c>DISPATCH_RULE</c>: Alert notifications are sent based on the specified notification policy.</para>
            /// </description></item>
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
            /// <item><description><para><c>1</c>: The alert rule is enabled.</para>
            /// </description></item>
            /// <item><description><para><c>0</c>: The alert rule is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The type of the alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Kubernetes组件告警</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9FEA6D00-317F-45E3-9004-7FB8B0B7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c></para>
        /// </description></item>
        /// <item><description><para><c>false</c></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
