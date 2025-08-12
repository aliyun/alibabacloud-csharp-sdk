// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeProductsOfActiveMetricRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the services for which one-click alert is enabled.</para>
        /// </summary>
        [NameInMap("AllProductInitMetricRuleList")]
        [Validation(Required=false)]
        public DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleList AllProductInitMetricRuleList { get; set; }
        public class DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleList : TeaModel {
            [NameInMap("AllProductInitMetricRule")]
            [Validation(Required=false)]
            public List<DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRule> AllProductInitMetricRule { get; set; }
            public class DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRule : TeaModel {
                /// <summary>
                /// <para>The initial alert rules that are generated after one-click alert is enabled for a service.</para>
                /// </summary>
                [NameInMap("AlertInitConfigList")]
                [Validation(Required=false)]
                public DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRuleAlertInitConfigList AlertInitConfigList { get; set; }
                public class DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRuleAlertInitConfigList : TeaModel {
                    [NameInMap("AlertInitConfig")]
                    [Validation(Required=false)]
                    public List<DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRuleAlertInitConfigListAlertInitConfig> AlertInitConfig { get; set; }
                    public class DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRuleAlertInitConfigListAlertInitConfig : TeaModel {
                        /// <summary>
                        /// <para>The operator that is used to compare the metric value with the threshold for Warn-level alerts.</para>
                        /// <para>Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>LessThanThreshold: less than the threshold</para>
                        /// </description></item>
                        /// <item><description><para>GreaterThanLastWeek: greater than the metric value at the same time last week</para>
                        /// </description></item>
                        /// <item><description><para>LessThanOrEqualToThreshold: less than or equal to the threshold</para>
                        /// </description></item>
                        /// <item><description><para>NotEqualToThreshold: does not equal to the threshold</para>
                        /// </description></item>
                        /// <item><description><para>GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle</para>
                        /// </description></item>
                        /// <item><description><para>GreaterThanYesterday: greater than the metric value at the same time yesterday</para>
                        /// </description></item>
                        /// <item><description><para>LessThanYesterday: less than the metric value at the same time yesterday</para>
                        /// </description></item>
                        /// <item><description><para>LessThanLastWeek: less than the metric value at the same time last week</para>
                        /// </description></item>
                        /// <item><description><para>GreaterThanOrEqualToThreshold: greater than or equal to the threshold</para>
                        /// </description></item>
                        /// <item><description><para>GreaterThanThreshold: greater than the threshold</para>
                        /// </description></item>
                        /// <item><description><para>LessThanLastPeriod: less than the metric value in the last monitoring cycle</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>GreaterThanOrEqualToThreshold</para>
                        /// </summary>
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        /// <summary>
                        /// <para>The consecutive number of times for which the metric value meets the alert condition before an alert is triggered.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("EvaluationCount")]
                        [Validation(Required=false)]
                        public string EvaluationCount { get; set; }

                        /// <summary>
                        /// <para>The alert level.</para>
                        /// <para>Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>INFO</para>
                        /// <!-- -->
                        /// 
                        /// <!-- -->
                        /// 
                        /// <!-- -->
                        /// </description></item>
                        /// <item><description><para>WARN</para>
                        /// <!-- -->
                        /// 
                        /// <!-- -->
                        /// 
                        /// <!-- -->
                        /// </description></item>
                        /// <item><description><para>CRITICAL</para>
                        /// <!-- -->
                        /// 
                        /// <!-- -->
                        /// 
                        /// <!-- --></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CRITICAL</para>
                        /// </summary>
                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        /// <summary>
                        /// <para>The metric name. For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cpu_total</para>
                        /// </summary>
                        [NameInMap("MetricName")]
                        [Validation(Required=false)]
                        public string MetricName { get; set; }

                        /// <summary>
                        /// <para>The namespace of the service. For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>acs_rds_dashboard</para>
                        /// </summary>
                        [NameInMap("Namespace")]
                        [Validation(Required=false)]
                        public string Namespace { get; set; }

                        /// <summary>
                        /// <para>The aggregation period of monitoring data. Unit: minutes. For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1m</para>
                        /// </summary>
                        [NameInMap("Period")]
                        [Validation(Required=false)]
                        public string Period { get; set; }

                        /// <summary>
                        /// <para>The method used to calculate metric values that trigger alerts. For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Average</para>
                        /// </summary>
                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        /// <summary>
                        /// <para>The alert threshold.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>90</para>
                        /// </summary>
                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                    }

                }

                /// <summary>
                /// <para>The abbreviation of the service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about the services for which the initiative alert feature is enabled. Services are separated with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ECS: Elastic Compute Service (ECS)</description></item>
        /// <item><description>rds: ApsaraDB RDS</description></item>
        /// <item><description>slb: Server Load Balancer (SLB)</description></item>
        /// <item><description>redis_standard: Redis Open-Source Edition (standard architecture)</description></item>
        /// <item><description>redis_sharding: Redis Open-Source Edition (cluster architecture)</description></item>
        /// <item><description>redis_splitrw: Redis Open-Source Edition (read/write splitting architecture)</description></item>
        /// <item><description>mongodb: ApsaraDB for MongoDB of the replica set architecture</description></item>
        /// <item><description>mongodb_sharding: ApsaraDB for MongoDB of the sharded cluster architecture</description></item>
        /// <item><description>hbase: ApsaraDB for HBase</description></item>
        /// <item><description>elasticsearch: Elasticsearch</description></item>
        /// <item><description>opensearch: OpenSearch</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs,rds</para>
        /// </summary>
        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public string Datapoints { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Request is not authorization.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F82E6667-7811-4BA0-842F-5B2DC42BBAAD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
