// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyMetricRuleTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The list of alert templates.</para>
        /// </summary>
        [NameInMap("AlertTemplates")]
        [Validation(Required=false)]
        public List<ModifyMetricRuleTemplateRequestAlertTemplates> AlertTemplates { get; set; }
        public class ModifyMetricRuleTemplateRequestAlertTemplates : TeaModel {
            [NameInMap("Escalations")]
            [Validation(Required=false)]
            public ModifyMetricRuleTemplateRequestAlertTemplatesEscalations Escalations { get; set; }
            public class ModifyMetricRuleTemplateRequestAlertTemplatesEscalations : TeaModel {
                [NameInMap("Critical")]
                [Validation(Required=false)]
                public ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsCritical Critical { get; set; }
                public class ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsCritical : TeaModel {
                    /// <summary>
                    /// <para>The comparison operator for the critical-level alert threshold. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold. </description></item>
                    /// <item><description>GreaterThanThreshold: greater than the threshold. </description></item>
                    /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold. </description></item>
                    /// <item><description>LessThanThreshold: less than the threshold. </description></item>
                    /// <item><description>NotEqualToThreshold: not equal to the threshold. </description></item>
                    /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday. </description></item>
                    /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday. </description></item>
                    /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week. </description></item>
                    /// <item><description>LessThanLastWeek: less than the metric value at the same time last week. </description></item>
                    /// <item><description>GreaterThanLastPeriod: greater than the metric value in the previous period. </description></item>
                    /// <item><description>LessThanLastPeriod: less than the metric value in the previous period.</description></item>
                    /// </list>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, and Info. The Statistics, ComparisonOperator, Threshold, and Times parameters must be specified at the same time for the specified alert level.</para>
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
                    /// <para>The valid values of this parameter are determined by the <c>Statistics</c> column that corresponds to the <c>MetricName</c> parameter of the specified Alibaba Cloud service, such as Maximum, Minimum, and Average. For more information about how to obtain the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">cloud service monitoring metrics</a>.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, and Info. The Statistics, ComparisonOperator, Threshold, and Times parameters must be specified at the same time for the specified alert level.</para>
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
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, and Info. The Statistics, ComparisonOperator, Threshold, and Times parameters must be specified at the same time for the specified alert level.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>The number of times that the monitoring metrics must reach the alert threshold to send a critical-level alert notification.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, and Info. The Statistics, ComparisonOperator, Threshold, and Times parameters must be specified at the same time for the specified alert level.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

                [NameInMap("Info")]
                [Validation(Required=false)]
                public ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsInfo Info { get; set; }
                public class ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsInfo : TeaModel {
                    /// <summary>
                    /// <para>The comparison operator for the info-level alert threshold. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold. </description></item>
                    /// <item><description>GreaterThanThreshold: greater than the threshold. </description></item>
                    /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold. </description></item>
                    /// <item><description>LessThanThreshold: less than the threshold. </description></item>
                    /// <item><description>NotEqualToThreshold: not equal to the threshold. </description></item>
                    /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday. </description></item>
                    /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday. </description></item>
                    /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week. </description></item>
                    /// <item><description>LessThanLastWeek: less than the metric value at the same time last week. </description></item>
                    /// <item><description>GreaterThanLastPeriod: greater than the metric value in the previous period. </description></item>
                    /// <item><description>LessThanLastPeriod: less than the metric value in the previous period.</description></item>
                    /// </list>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, and Info. The Statistics, ComparisonOperator, Threshold, and Times parameters must be specified at the same time for the specified alert level.</para>
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
                    /// <para>The valid values of this parameter are determined by the <c>Statistics</c> column that corresponds to the <c>MetricName</c> parameter of the specified Alibaba Cloud service, such as Maximum, Minimum, and Average. For more information about how to obtain the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">cloud service monitoring metrics</a>.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, and Info. The Statistics, ComparisonOperator, Threshold, and Times parameters must be specified at the same time for the specified alert level.</para>
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
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, and Info. The Statistics, ComparisonOperator, Threshold, and Times parameters must be specified at the same time for the specified alert level.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>The number of times that the monitoring metrics must reach the alert threshold to send an info-level alert notification.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, and Info. The Statistics, ComparisonOperator, Threshold, and Times parameters must be specified at the same time for the specified alert level.</para>
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
                public ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsWarn Warn { get; set; }
                public class ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsWarn : TeaModel {
                    /// <summary>
                    /// <para>The comparison operator for the warning-level alert threshold. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold. </description></item>
                    /// <item><description>GreaterThanThreshold: greater than the threshold. </description></item>
                    /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold. </description></item>
                    /// <item><description>LessThanThreshold: less than the threshold. </description></item>
                    /// <item><description>NotEqualToThreshold: not equal to the threshold. </description></item>
                    /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday. </description></item>
                    /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday. </description></item>
                    /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week. </description></item>
                    /// <item><description>LessThanLastWeek: less than the metric value at the same time last week. </description></item>
                    /// <item><description>GreaterThanLastPeriod: greater than the metric value in the previous period. </description></item>
                    /// <item><description>LessThanLastPeriod: less than the metric value in the previous period.</description></item>
                    /// </list>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, and Info. The Statistics, ComparisonOperator, Threshold, and Times parameters must be specified at the same time for the specified alert level.</para>
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
                    /// <para>The statistical method for warning-level alerts.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <para>The valid values of this parameter are determined by the <c>Statistics</c> column that corresponds to the <c>MetricName</c> parameter of the specified Alibaba Cloud service, such as Maximum, Minimum, and Average. For more information about how to obtain the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/163515.html">cloud service monitoring metrics</a>.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, and Info. The Statistics, ComparisonOperator, Threshold, and Times parameters must be specified at the same time for the specified alert level.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Average</para>
                    /// </summary>
                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    /// <summary>
                    /// <para>The threshold for warning-level alerts.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, and Info. The Statistics, ComparisonOperator, Threshold, and Times parameters must be specified at the same time for the specified alert level.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    /// <summary>
                    /// <para>The number of times that the monitoring metrics must reach the alert threshold to send a warning-level alert notification.</para>
                    /// <para>Valid values of N: 1 to 200.</para>
                    /// <remarks>
                    /// <para>You must specify at least one of the following alert levels: Critical, Warn, and Info. The Statistics, ComparisonOperator, Threshold, and Times parameters must be specified at the same time for the specified alert level.</para>
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
            /// <para>The abbreviation of the Alibaba Cloud service name. Valid values of N: 1 to 200. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ecs: Alibaba Cloud and non-Alibaba Cloud hosts.</description></item>
            /// <item><description>rds: ApsaraDB RDS database.</description></item>
            /// <item><description>ads: AnalyticDB database.</description></item>
            /// <item><description>slb: load balancing.</description></item>
            /// <item><description>vpc: Elastic IP Address (EIP).</description></item>
            /// <item><description>apigateway: API Gateway.</description></item>
            /// <item><description>cdn: Content Delivery Network (CDN).</description></item>
            /// <item><description>cs: Container Service for Swarm.</description></item>
            /// <item><description>dcdn: Dynamic Route for CDN (DCDN).</description></item>
            /// <item><description>ddos: Anti-DDoS.</description></item>
            /// <item><description>eip: Elastic IP Address (EIP).</description></item>
            /// <item><description>elasticsearch: Elasticsearch.</description></item>
            /// <item><description>emr: E-MapReduce (EMR).</description></item>
            /// <item><description>ess: elastic scaling.</description></item>
            /// <item><description>hbase: ApsaraDB for HBase database.</description></item>
            /// <item><description>iot_edge: IoT Edge.</description></item>
            /// <item><description>kvstore_sharding: ApsaraDB for Redis Cluster Edition.</description></item>
            /// <item><description>kvstore_splitrw: ApsaraDB for Redis Read/Write Splitting Edition.</description></item>
            /// <item><description>kvstore_standard: ApsaraDB for Redis Standard Edition.</description></item>
            /// <item><description>memcache: ApsaraDB for Memcache database.</description></item>
            /// <item><description>mns: Message Service (MNS).</description></item>
            /// <item><description>mongodb: MongoDB replica set instance.</description></item>
            /// <item><description>mongodb_cluster: MongoDB cluster edition.</description></item>
            /// <item><description>mongodb_sharding: MongoDB sharded cluster.</description></item>
            /// <item><description>mq_topic: Message Service Topic.</description></item>
            /// <item><description>ocs: legacy cloud database Memcache.</description></item>
            /// <item><description>opensearch: OpenSearch.</description></item>
            /// <item><description>oss: Object Storage Service (OSS).</description></item>
            /// <item><description>polardb: PolarDB database.</description></item>
            /// <item><description>petadata: HybridDB for MySQL.</description></item>
            /// <item><description>scdn: secure acceleration.</description></item>
            /// <item><description>sharebandwidthpackages: Internet Shared Bandwidth.</description></item>
            /// <item><description>sls: Simple Log Service (SLS).</description></item>
            /// <item><description>vpn: VPN Gateway.</description></item>
            /// </list>
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
            /// <para>For more information about the valid values of the metric name, see <a href="https://help.aliyun.com/document_detail/114972.html">DescribeSystemEventMetaList</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cpu_total</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The namespace of the Alibaba Cloud service, which is used to distinguish different services. Valid values of N: 1 to 200.</para>
            /// <para>Format: acs_<service name>.</para>
            /// <remarks>
            /// <para>To obtain the namespace of each Alibaba Cloud service, call the <a href="https://help.aliyun.com/document_detail/114916.html">DescribeProjectMeta</a> operation.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>acs_ecs_dashboard</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The statistical period of the monitoring data. Valid values of N: 1 to 200.</para>
            /// <remarks>
            /// <para>If you set this parameter to 300, the system collects and aggregates monitoring data every 300 seconds. If monitoring data is reported every minute, the system aggregates the data of 5 minutes, such as the average, maximum, and minimum values. Do not specify this parameter separately because the statistical period may cause unexpected alerts.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The name of the alert rule. Valid values of N: 1 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule1</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The options for the extended dimension fields. Valid values of N: 1 to 200.</para>
            /// <para>For example, if the alert template is applied to an application group, this parameter is set to <c>{&quot;disk&quot;:&quot;/&quot;}</c>, and the MetricName parameter is set to <c>DiskUtilization</c>, the root partition (<c>&quot;/&quot;</c>) of the disks for all instances in the application group is associated with the corresponding alert rule.</para>
            /// <remarks>
            /// <para>For more information about the valid values of the extended dimension fields, see <a href="https://help.aliyun.com/document_detail/114972.html">DescribeSystemEventMetaList</a>.</para>
            /// </remarks>
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
            /// <para><a href="https://apiwebhook.hipac.cn/api/v1/alarm/aly/eregfeeferrtbnmkdszp">https://apiwebhook.hipac.cn/api/v1/alarm/aly/eregfeeferrtbnmkdszp</a></para>
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

        /// <summary>
        /// <para>The description of the alert template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_template1</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the alert template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The version of the alert template to be modified.</para>
        /// <remarks>
        /// <para>This parameter is automatically updated based on the number of modifications.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RestVersion")]
        [Validation(Required=false)]
        public long? RestVersion { get; set; }

        /// <summary>
        /// <para>The ID of the alert template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
