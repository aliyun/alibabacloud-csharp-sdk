// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateGroupMetricRulesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application group.</para>
        /// <para>For information about how to obtain the ID of an application group, see <a href="https://help.aliyun.com/document_detail/115032.html">DescribeMonitorGroups</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("GroupMetricRules")]
        [Validation(Required=false)]
        public List<CreateGroupMetricRulesRequestGroupMetricRules> GroupMetricRules { get; set; }
        public class CreateGroupMetricRulesRequestGroupMetricRules : TeaModel {
            [NameInMap("Escalations")]
            [Validation(Required=false)]
            public CreateGroupMetricRulesRequestGroupMetricRulesEscalations Escalations { get; set; }
            public class CreateGroupMetricRulesRequestGroupMetricRulesEscalations : TeaModel {
                [NameInMap("Critical")]
                [Validation(Required=false)]
                public CreateGroupMetricRulesRequestGroupMetricRulesEscalationsCritical Critical { get; set; }
                public class CreateGroupMetricRulesRequestGroupMetricRulesEscalationsCritical : TeaModel {
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public string N { get; set; }

                    [NameInMap("PreCondition")]
                    [Validation(Required=false)]
                    public string PreCondition { get; set; }

                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

                [NameInMap("Info")]
                [Validation(Required=false)]
                public CreateGroupMetricRulesRequestGroupMetricRulesEscalationsInfo Info { get; set; }
                public class CreateGroupMetricRulesRequestGroupMetricRulesEscalationsInfo : TeaModel {
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public string N { get; set; }

                    [NameInMap("PreCondition")]
                    [Validation(Required=false)]
                    public string PreCondition { get; set; }

                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

                [NameInMap("Warn")]
                [Validation(Required=false)]
                public CreateGroupMetricRulesRequestGroupMetricRulesEscalationsWarn Warn { get; set; }
                public class CreateGroupMetricRulesRequestGroupMetricRulesEscalationsWarn : TeaModel {
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public string N { get; set; }

                    [NameInMap("PreCondition")]
                    [Validation(Required=false)]
                    public string PreCondition { get; set; }

                    [NameInMap("Statistics")]
                    [Validation(Required=false)]
                    public string Statistics { get; set; }

                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public string Threshold { get; set; }

                    [NameInMap("Times")]
                    [Validation(Required=false)]
                    public int? Times { get; set; }

                }

            }

            /// <summary>
            /// <para>The name of the cloud service. Valid values of N: 1 to 200. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>PolarDB: PolarDB</description></item>
            /// <item><description>NewBGPDDoS: Anti-DDoS Pro</description></item>
            /// <item><description>IoTDevice: IoT Platform</description></item>
            /// <item><description>DRDS: Distributed Relational Database Service (DRDS)</description></item>
            /// <item><description>VS: Video Surveillance System</description></item>
            /// <item><description>AMQP: Alibaba Cloud Message Queue for AMQP</description></item>
            /// <item><description>ADS: AnalyticDB</description></item>
            /// <item><description>APIGateway: API Gateway</description></item>
            /// <item><description>InternetSharedBandwidth: EIP Bandwidth Plan</description></item>
            /// <item><description>CDN: Alibaba Cloud Content Delivery Network (CDN)</description></item>
            /// <item><description>CEN: Cloud Enterprise Network (CEN)</description></item>
            /// <item><description>DCDN: Dynamic Route for CDN (DCDN)</description></item>
            /// <item><description>DDoS: Anti-DDoS</description></item>
            /// <item><description>ECS: Elastic Compute Service (ECS)</description></item>
            /// <item><description>DirectMail: Direct Mail</description></item>
            /// <item><description>Elasticsearch: Elasticsearch</description></item>
            /// <item><description>EMR: E-MapReduce (EMR)</description></item>
            /// <item><description>ESS: Auto Scaling</description></item>
            /// <item><description>FunctionCompute: Function Compute</description></item>
            /// <item><description>RealtimeCompute: Realtime Compute for Apache Flink</description></item>
            /// <item><description>GlobalAcceleration: Global Accelerator (GA)</description></item>
            /// <item><description>Hbase: ApsaraDB for HBase</description></item>
            /// <item><description>TSDB: Time Series Database (TSDB)</description></item>
            /// <item><description>IPv6trans: IPv6 Translation Service</description></item>
            /// <item><description>Kafka: Message Queue for Apache Kafka</description></item>
            /// <item><description>Kubernetes: Container Service for Kubernetes (ACK)</description></item>
            /// <item><description>KVstore: ApsaraDB for Redis</description></item>
            /// <item><description>MNS: Message Service (MNS)</description></item>
            /// <item><description>MongoDB: ApsaraDB for MongoDB</description></item>
            /// <item><description>MQ: Message Queue</description></item>
            /// <item><description>NAT: NAT Gateway</description></item>
            /// <item><description>OpenAd: Open Ad</description></item>
            /// <item><description>OpenSearch: Open Search</description></item>
            /// <item><description>OSS: Object Storage Service (OSS)</description></item>
            /// <item><description>PCDN: P2P CDN</description></item>
            /// <item><description>petadata: HybridDB for MySQL</description></item>
            /// <item><description>RDS: ApsaraDB RDS</description></item>
            /// <item><description>SCDN: Secure CDN</description></item>
            /// <item><description>SLB: Server Load Balancer (SLB)</description></item>
            /// <item><description>SLS: Log Service</description></item>
            /// <item><description>VideoLive: ApsaraVideo Live</description></item>
            /// <item><description>VOD: ApsaraVideo VOD</description></item>
            /// <item><description>EIP: Elastic IP Address (EIP)</description></item>
            /// <item><description>VPN: VPN Gateway</description></item>
            /// <item><description>AIRec: Artificial Intelligence Recommendation</description></item>
            /// <item><description>GPDB: AnalyticDB for PostgreSQL</description></item>
            /// <item><description>DBS: Database Backup (DBS)</description></item>
            /// <item><description>SAG: Smart Access Gateway (SAG)</description></item>
            /// <item><description>Memcache: ApsaraDB for Memcache</description></item>
            /// <item><description>IOT_EDGE: Link IoT Edge</description></item>
            /// <item><description>OCS: ApsaraDB for Memcache (previous version)</description></item>
            /// <item><description>VPC: Express Connect</description></item>
            /// <item><description>EHPC: Elastic High Performance Computing (E-HPC)</description></item>
            /// <item><description>MPS: ApsaraVideo Media Processing</description></item>
            /// <item><description>ENS: Edge Node Service (ENS)</description></item>
            /// <item><description>MaxCompute_Prepay: MaxCompute</description></item>
            /// <item><description>IoT_Kubernetes: Edge Application Hosting</description></item>
            /// <item><description>CMS: CloudMonitor</description></item>
            /// <item><description>batchcomputenew: Batch Compute</description></item>
            /// <item><description>HBaseUE: ApsaraDB for HBase Performance-enhanced Edition</description></item>
            /// <item><description>UIS: Ultimate Internet Service (UIS)</description></item>
            /// <item><description>nls: Intelligent Speech Interaction</description></item>
            /// <item><description>ots: Tablestore</description></item>
            /// <item><description>NAS: File Storage NAS</description></item>
            /// <item><description>ECI: Elastic Container Instance (ECI)</description></item>
            /// <item><description>OpenAPI: OpenAPI Explorer</description></item>
            /// <item><description>pvtzpost: Alibaba Cloud DNS PrivateZone</description></item>
            /// <item><description>blinkonk8s: Flink on Kubernetes</description></item>
            /// <item><description>FunctionFlow: Serverless Workflow (SWF)</description></item>
            /// <item><description>SMC: Server Migration Center (SMC)</description></item>
            /// <item><description>ddosbgp: Anti-DDoS Origin</description></item>
            /// <item><description>baas: Blockchain as a Service</description></item>
            /// <item><description>privatelink: PrivateLink</description></item>
            /// <item><description>cds: ApsaraDB for Cassandra</description></item>
            /// <item><description>DDH: Dedicated Host</description></item>
            /// <item><description>RocketMQ: Message Queue for Apache RocketMQ</description></item>
            /// <item><description>ECC: Express Cloud Connect</description></item>
            /// <item><description>hbaseserverless: ApsaraDB for HBase Serverless Edition</description></item>
            /// <item><description>mns_tmp: Message Service</description></item>
            /// <item><description>hdr: Hybrid Disaster Recovery (HDR)</description></item>
            /// <item><description>hbr: Hybrid Backup Recovery (HBR)</description></item>
            /// <item><description>ADB: AnalyticDB for MySQL V3.0</description></item>
            /// <item><description>tag: Tag Service</description></item>
            /// <item><description>GDB: Graph Database</description></item>
            /// <item><description>WAF: Web Application Firewall (WAF)</description></item>
            /// <item><description>hcs_sgw: Cloud Storage Gateway (CSG)</description></item>
            /// <item><description>ipv6gateway: IPv6 Gateway</description></item>
            /// <item><description>RDS_SAR: ApsaraDB Exclusive Host Group</description></item>
            /// <item><description>learn: Machine Learning Platform for AI</description></item>
            /// <item><description>ROS: Resource Orchestration Service (ROS)</description></item>
            /// <item><description>OOS: Operation Orchestration Service (OOS)</description></item>
            /// <item><description>bds: Data Synchronization for HBase</description></item>
            /// <item><description>cfw: Cloud Firewall</description></item>
            /// <item><description>ddosDip: Anti-DDoS Premium</description></item>
            /// <item><description>datahub: DataHub</description></item>
            /// <item><description>hologres: Hologres</description></item>
            /// <item><description>ExpressConnect: Express Connect</description></item>
            /// <item><description>dbfs: Database File System (DBFS)</description></item>
            /// <item><description>clickhouse: ApsaraDB for ClickHouse</description></item>
            /// <item><description>k8s: Container Service for Kubernetes (ACK)</description></item>
            /// <item><description>DTS: Data Transmission Service (DTS)</description></item>
            /// <item><description>AnycastEIP: Anycast Elastic IP Address</description></item>
            /// <item><description>Lindorm: ApsaraDB for Lindorm</description></item>
            /// <item><description>config: Cloud Config</description></item>
            /// <item><description>spark: Databricks DataInsight (DDI)</description></item>
            /// <item><description>serverless: Serverless App Engine (SAE)</description></item>
            /// <item><description>alb: Application Load Balancer (ALB)</description></item>
            /// <item><description>oceanbase: ApsaraDB for OceanBase</description></item>
            /// <item><description>KMS: Key Management Service (KMS)</description></item>
            /// <item><description>lvwang: Content Moderation</description></item>
            /// <item><description>LinkVisual: LinkVisual</description></item>
            /// <item><description>tair: ApsaraDB for Redis Enhanced Edition (Tair)</description></item>
            /// <item><description>dlf: Data Lake Formation (DLF)</description></item>
            /// <item><description>networkmonitor: Site Monitoring</description></item>
            /// <item><description>pnc: Physical Network Change</description></item>
            /// <item><description>AIS: Alibaba Cloud Infrastructure</description></item>
            /// <item><description>cloudgame: Cloud Gaming Platform</description></item>
            /// <item><description>RTC: Real-Time Communication</description></item>
            /// <item><description>cloudbox: CloudBox</description></item>
            /// <item><description>actiontrail: ActionTrail</description></item>
            /// <item><description>cc: Cloud Connector</description></item>
            /// <item><description>disk: Elastic Block Storage (EBS)</description></item>
            /// <item><description>easygene: Genomics Computing Platform</description></item>
            /// <item><description>cloudphone: Elastic Cloud Phone</description></item>
            /// <item><description>BMS: Bare Metal Management Service</description></item>
            /// <item><description>swas: Simple Application Server</description></item>
            /// <item><description>AvailabilityMonitoring: Availability Monitoring of CloudMonitor</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The alert contact groups. Valid values of N: 1 to 200.</para>
            /// <para>For information about how to obtain alert contact groups, see <a href="https://help.aliyun.com/document_detail/114922.html">DescribeContactGroupList</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_Group</para>
            /// </summary>
            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public string ContactGroups { get; set; }

            /// <summary>
            /// <para>The dimension of the alert rule. Valid values of N: 1 to 200.</para>
            /// <para>Set the value to a set of key-value pairs, for example, <c>userId:120886317861****</c> or <c>instanceId:i-m5e1qg6uo38rztr4****</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;instanceId&quot;:&quot;i-m5e1qg6uo38rztr4****&quot;}]</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public string Dimensions { get; set; }

            /// <summary>
            /// <para>The time period during which the alert rule is effective. Valid values of N: 1 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>05:31-23:59</para>
            /// </summary>
            [NameInMap("EffectiveInterval")]
            [Validation(Required=false)]
            public string EffectiveInterval { get; set; }

            /// <summary>
            /// <para>The subject of the alert notification email. Valid values of N: 1 to 200.</para>
            /// </summary>
            [NameInMap("EmailSubject")]
            [Validation(Required=false)]
            public string EmailSubject { get; set; }

            /// <summary>
            /// <para>The interval at which CloudMonitor checks whether the alert rule is triggered. Valid values of N: 1 to 200.</para>
            /// <para>Unit: seconds. The default value is the lowest frequency at which the metric is polled.</para>
            /// <remarks>
            /// <para> We recommend that you set the interval to the data aggregation period. If the interval is shorter than the data aggregation period, alerts cannot be triggered due to insufficient data.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<CreateGroupMetricRulesRequestGroupMetricRulesLabels> Labels { get; set; }
            public class CreateGroupMetricRulesRequestGroupMetricRulesLabels : TeaModel {
                /// <summary>
                /// <para>The tag key of the alert rule. The specified tag is contained in alert notifications.</para>
                /// <para>Valid values of N: 1 to 200.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the alert rule. The specified tag is contained in alert notifications.</para>
                /// <para>Valid values of N: 1 to 200.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The name of the metric. Valid values of N: 1 to 200.</para>
            /// <para>For information about how to obtain the name of a metric, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a> or <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpu_total</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The namespace of the cloud service. Valid values of N: 1 to 200.</para>
            /// <para>For information about how to obtain the namespace of a cloud service, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a> or <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs_ecs_dashboard</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The method that is used to handle alerts when no monitoring data is found. Valid values of N: 1 to 200. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>KEEP_LAST_STATE (default value): No operation is performed.</description></item>
            /// <item><description>INSUFFICIENT_DATA: An alert whose content is &quot;Insufficient data&quot; is triggered.</description></item>
            /// <item><description>OK: The alert rule has no active alerts.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>KEEP_LAST_STATE</para>
            /// </summary>
            [NameInMap("NoDataPolicy")]
            [Validation(Required=false)]
            public string NoDataPolicy { get; set; }

            /// <summary>
            /// <para>The time period during which the alert rule is ineffective. Valid values of N: 1 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00-05:30</para>
            /// </summary>
            [NameInMap("NoEffectiveInterval")]
            [Validation(Required=false)]
            public string NoEffectiveInterval { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;NotSendOK&quot;: true
            /// }</para>
            /// </summary>
            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }

            /// <summary>
            /// <para>The aggregation period of the metric data. Valid values of N: 1 to 200.</para>
            /// <para>Set the <c>Period</c> parameter to an integral multiple of 60. Unit: seconds. Default value: 300.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// <para>The ID of the alert rule. Valid values of N: 1 to 200.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>456789</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the alert rule. Valid values of N: 1 to 200.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_Rule1</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The mute period during which new alerts are not sent even if the trigger conditions are met. Valid values of N: 1 to 200.</para>
            /// <para>Unit: seconds. Default value: 86400. Minimum value: 3600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public int? SilenceTime { get; set; }

            /// <summary>
            /// <para>The callback URL. Valid values of N: 1 to 200.</para>
            /// <para>The callback URL must be accessible over the Internet. CloudMonitor pushes an alert notification to the specified callback URL by sending an HTTP POST request. Only the HTTP protocol is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
