// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateMetricRuleTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The alert templates.</para>
        /// </summary>
        [NameInMap("AlertTemplates")]
        [Validation(Required=false)]
        public List<CreateMetricRuleTemplateRequestAlertTemplates> AlertTemplates { get; set; }
        public class CreateMetricRuleTemplateRequestAlertTemplates : TeaModel {
            [NameInMap("Escalations")]
            [Validation(Required=false)]
            public CreateMetricRuleTemplateRequestAlertTemplatesEscalations Escalations { get; set; }
            public class CreateMetricRuleTemplateRequestAlertTemplatesEscalations : TeaModel {
                [NameInMap("Critical")]
                [Validation(Required=false)]
                public CreateMetricRuleTemplateRequestAlertTemplatesEscalationsCritical Critical { get; set; }
                public class CreateMetricRuleTemplateRequestAlertTemplatesEscalationsCritical : TeaModel {
                    /// <summary>
                    /// <para>The comparison operator for the critical-level threshold. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to </description></item>
                    /// <item><description>GreaterThanThreshold: greater than </description></item>
                    /// <item><description>LessThanOrEqualToThreshold: less than or equal to </description></item>
                    /// <item><description>LessThanThreshold: less than </description></item>
                    /// <item><description>NotEqualToThreshold: not equal to </description></item>
                    /// <item><description>GreaterThanYesterday: greater than the value at the same time yesterday </description></item>
                    /// <item><description>LessThanYesterday: less than the value at the same time yesterday </description></item>
                    /// <item><description>GreaterThanLastWeek: greater than the value at the same time last week </description></item>
                    /// <item><description>LessThanLastWeek: less than the value at the same time last week </description></item>
                    /// <item><description>GreaterThanLastPeriod: greater than the value in the last period </description></item>
                    /// <item><description>LessThanLastPeriod: less than the value in the last period</description></item>
                    /// </list>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GreaterThanOrEqualToThreshold</para>
                    /// </summary>
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public int? N { get; set; }

                    /// <summary>
                    /// <para>The statistical method for critical-level alerts.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <para>The valid values of this parameter are determined by the <c>Statistics</c> column that corresponds to the <c>MetricName</c> of the specified cloud service. Examples: Maximum, Minimum, and Average. For more information about how to obtain the valid values, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Average</para>
                    /// </summary>
                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    /// <summary>
                    /// <para>The threshold that triggers a critical-level alert notification.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>The number of consecutive times the monitoring metrics must reach the alert threshold to send a critical-level alert notification.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

                [NameInMap("Info")]
                [Validation(Required=false)]
                public CreateMetricRuleTemplateRequestAlertTemplatesEscalationsInfo Info { get; set; }
                public class CreateMetricRuleTemplateRequestAlertTemplatesEscalationsInfo : TeaModel {
                    /// <summary>
                    /// <para>The comparison operator for the info-level threshold. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to </description></item>
                    /// <item><description>GreaterThanThreshold: greater than </description></item>
                    /// <item><description>LessThanOrEqualToThreshold: less than or equal to </description></item>
                    /// <item><description>LessThanThreshold: less than </description></item>
                    /// <item><description>NotEqualToThreshold: not equal to </description></item>
                    /// <item><description>GreaterThanYesterday: greater than the value at the same time yesterday </description></item>
                    /// <item><description>LessThanYesterday: less than the value at the same time yesterday </description></item>
                    /// <item><description>GreaterThanLastWeek: greater than the value at the same time last week </description></item>
                    /// <item><description>LessThanLastWeek: less than the value at the same time last week </description></item>
                    /// <item><description>GreaterThanLastPeriod: greater than the value in the last period </description></item>
                    /// <item><description>LessThanLastPeriod: less than the value in the last period</description></item>
                    /// </list>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GreaterThanOrEqualToThreshold</para>
                    /// </summary>
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public int? N { get; set; }

                    /// <summary>
                    /// <para>The statistical method for info-level alerts.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <para>The valid values of this parameter are determined by the <c>Statistics</c> column that corresponds to the <c>MetricName</c> of the specified cloud service. Examples: Maximum, Minimum, and Average. For more information about how to obtain the valid values, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Average</para>
                    /// </summary>
                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    /// <summary>
                    /// <para>The threshold for info-level alerts.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>The number of consecutive times the monitoring metrics must reach the alert threshold to send an info-level alert notification.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

                [NameInMap("Warn")]
                [Validation(Required=false)]
                public CreateMetricRuleTemplateRequestAlertTemplatesEscalationsWarn Warn { get; set; }
                public class CreateMetricRuleTemplateRequestAlertTemplatesEscalationsWarn : TeaModel {
                    /// <summary>
                    /// <para>The comparison operator for the warn-level threshold. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to </description></item>
                    /// <item><description>GreaterThanThreshold: greater than </description></item>
                    /// <item><description>LessThanOrEqualToThreshold: less than or equal to </description></item>
                    /// <item><description>LessThanThreshold: less than </description></item>
                    /// <item><description>NotEqualToThreshold: not equal to </description></item>
                    /// <item><description>GreaterThanYesterday: greater than the value at the same time yesterday </description></item>
                    /// <item><description>LessThanYesterday: less than the value at the same time yesterday </description></item>
                    /// <item><description>GreaterThanLastWeek: greater than the value at the same time last week </description></item>
                    /// <item><description>LessThanLastWeek: less than the value at the same time last week </description></item>
                    /// <item><description>GreaterThanLastPeriod: greater than the value in the last period </description></item>
                    /// <item><description>LessThanLastPeriod: less than the value in the last period</description></item>
                    /// </list>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GreaterThanOrEqualToThreshold</para>
                    /// </summary>
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public int? N { get; set; }

                    /// <summary>
                    /// <para>The statistical method for warning alerts.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <para>The valid values of this parameter are determined by the <c>Statistics</c> column that corresponds to the <c>MetricName</c> of the specified cloud service. Examples: Maximum, Minimum, and Average. For more information about how to obtain the valid values, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service monitoring metrics</a>.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Average</para>
                    /// </summary>
                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    /// <summary>
                    /// <para>The threshold for warn-level alerts.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>The number of consecutive times the monitoring metrics must reach the alert threshold to send a warning alert notification.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, or Info. For the specified alert level, you must specify the Statistics, ComparisonOperator, Threshold, and Times parameters at the same time.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

            }

            /// <summary>
            /// <para>The Alibaba Cloud service name or product specification abbreviation. Valid values of N: 1 to 200. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ecs: ECS instances and non-Alibaba Cloud hosts</description></item>
            /// <item><description>rds: ApsaraDB RDS database</description></item>
            /// <item><description>ads: AnalyticDB database</description></item>
            /// <item><description>slb: load balancing</description></item>
            /// <item><description>vpc: Elastic IP</description></item>
            /// <item><description>apigateway: API Gateway</description></item>
            /// <item><description>cdn: Content Delivery Network</description></item>
            /// <item><description>cs: Container Service for Swarm</description></item>
            /// <item><description>dcdn: Dynamic Route for CDN</description></item>
            /// <item><description>ddos: Anti-DDoS</description></item>
            /// <item><description>eip: Elastic IP Address</description></item>
            /// <item><description>elasticsearch: Elasticsearch</description></item>
            /// <item><description>emr: E-MapReduce</description></item>
            /// <item><description>ess: elastic scaling</description></item>
            /// <item><description>hbase: ApsaraDB for HBase database</description></item>
            /// <item><description>iot_edge: IoT Edge</description></item>
            /// <item><description>k8s_pod: Kubernetes pod</description></item>
            /// <item><description>kvstore_sharding: ApsaraDB for Redis Cluster Edition</description></item>
            /// <item><description>kvstore_splitrw: ApsaraDB for Redis Read/Write Splitting Edition</description></item>
            /// <item><description>kvstore_standard: ApsaraDB for Redis Standard Edition</description></item>
            /// <item><description>memcache: ApsaraDB for Memcache database</description></item>
            /// <item><description>mns: Message Service</description></item>
            /// <item><description>mongodb: MongoDB replica set</description></item>
            /// <item><description>mongodb_cluster: MongoDB cluster edition</description></item>
            /// <item><description>mongodb_sharding: MongoDB sharded cluster</description></item>
            /// <item><description>mq_topic: Message Service topic</description></item>
            /// <item><description>ocs: legacy ApsaraDB for Memcache database</description></item>
            /// <item><description>opensearch: OpenSearch</description></item>
            /// <item><description>oss: Object Storage Service</description></item>
            /// <item><description>polardb: PolarDB database</description></item>
            /// <item><description>petadata: HybridDB for MySQL</description></item>
            /// <item><description>scdn: secure acceleration</description></item>
            /// <item><description>sharebandwidthpackages: Internet Shared Bandwidth</description></item>
            /// <item><description>sls: Simple Log Service</description></item>
            /// <item><description>vpn: VPN Gateway</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The name of the metric. Valid values of N: 1 to 200.</para>
            /// <remarks>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a> or <a href="https://help.aliyun.com/document_detail/28619.html">Cloud service metrics</a>.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpu_total</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The namespace of the Alibaba Cloud service. Valid values of N: 1 to 200.</para>
            /// <remarks>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a> or <a href="https://help.aliyun.com/document_detail/28619.html">Cloud service metrics</a>.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs_ecs_dashboard</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The aggregation period of the monitoring data. Unit: seconds.</para>
            /// <para>Default value: the minimum aggregation period of the metric. You do not need to specify this parameter in most cases.</para>
            /// <para>Valid values of N: 1 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The name of the alert rule. Valid values of N: 1 to 200.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>My CPU monitoring</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The options for extended fields. Valid values of N: 1 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;disk&quot;:&quot;/&quot;}</para>
            /// </summary>
            [NameInMap("Selector")]
            [Validation(Required=false)]
            public string Selector { get; set; }

            /// <summary>
            /// <para>The webhook URL to which a POST request is sent when an alert is triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://ww.aliyun.com">http://ww.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

        /// <summary>
        /// <para>The description of the alert template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_Template1</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the alert template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Template1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
