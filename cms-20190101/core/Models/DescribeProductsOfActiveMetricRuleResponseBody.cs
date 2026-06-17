// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeProductsOfActiveMetricRuleResponseBody : TeaModel {
        [NameInMap("AllProductInitMetricRuleList")]
        [Validation(Required=false)]
        public DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleList AllProductInitMetricRuleList { get; set; }
        public class DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleList : TeaModel {
            [NameInMap("AllProductInitMetricRule")]
            [Validation(Required=false)]
            public List<DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRule> AllProductInitMetricRule { get; set; }
            public class DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRule : TeaModel {
                [NameInMap("AlertInitConfigList")]
                [Validation(Required=false)]
                public DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRuleAlertInitConfigList AlertInitConfigList { get; set; }
                public class DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRuleAlertInitConfigList : TeaModel {
                    [NameInMap("AlertInitConfig")]
                    [Validation(Required=false)]
                    public List<DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRuleAlertInitConfigListAlertInitConfig> AlertInitConfig { get; set; }
                    public class DescribeProductsOfActiveMetricRuleResponseBodyAllProductInitMetricRuleListAllProductInitMetricRuleAlertInitConfigListAlertInitConfig : TeaModel {
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        [NameInMap("EvaluationCount")]
                        [Validation(Required=false)]
                        public string EvaluationCount { get; set; }

                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        [NameInMap("MetricName")]
                        [Validation(Required=false)]
                        public string MetricName { get; set; }

                        [NameInMap("Namespace")]
                        [Validation(Required=false)]
                        public string Namespace { get; set; }

                        [NameInMap("Period")]
                        [Validation(Required=false)]
                        public string Period { get; set; }

                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                    }

                }

                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para>The status code 200 indicates that the request was successful.</para>
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
        /// <item><description><para>ECS: Elastic Compute Service (ECS)</para>
        /// </description></item>
        /// <item><description><para>rds: ApsaraDB RDS</para>
        /// </description></item>
        /// <item><description><para>slb: Server Load Balancer (SLB)</para>
        /// </description></item>
        /// <item><description><para>redis_standard: Redis Open-Source Edition (standard architecture)</para>
        /// </description></item>
        /// <item><description><para>redis_sharding: Redis Open-Source Edition (cluster architecture)</para>
        /// </description></item>
        /// <item><description><para>redis_splitrw: Redis Open-Source Edition (read/write splitting architecture)</para>
        /// </description></item>
        /// <item><description><para>mongodb: ApsaraDB for MongoDB of the replica set architecture</para>
        /// </description></item>
        /// <item><description><para>mongodb_sharding: ApsaraDB for MongoDB of the sharded cluster architecture</para>
        /// </description></item>
        /// <item><description><para>hbase: ApsaraDB for HBase</para>
        /// </description></item>
        /// <item><description><para>elasticsearch: Elasticsearch</para>
        /// </description></item>
        /// <item><description><para>opensearch: OpenSearch</para>
        /// </description></item>
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
        /// <item><description><para>true: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
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
