// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateGroupMetricRulesRequest : TeaModel {
        /// <summary>
        /// The ID of the application group.
        /// 
        /// For information about how to obtain the ID of an application group, see [DescribeMonitorGroups](https://help.aliyun.com/document_detail/115032.html).
        /// 
        /// This parameter is required.
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
            /// The name of the cloud service. Valid values of N: 1 to 200. Valid value:
            /// 
            /// *   PolarDB: PolarDB
            /// *   NewBGPDDoS: Anti-DDoS Pro
            /// *   IoTDevice: IoT Platform
            /// *   DRDS: Distributed Relational Database Service (DRDS)
            /// *   VS: Video Surveillance System
            /// *   AMQP: Alibaba Cloud Message Queue for AMQP
            /// *   ADS: AnalyticDB
            /// *   APIGateway: API Gateway
            /// *   InternetSharedBandwidth: EIP Bandwidth Plan
            /// *   CDN: Alibaba Cloud Content Delivery Network (CDN)
            /// *   CEN: Cloud Enterprise Network (CEN)
            /// *   DCDN: Dynamic Route for CDN (DCDN)
            /// *   DDoS: Anti-DDoS
            /// *   ECS: Elastic Compute Service (ECS)
            /// *   DirectMail: Direct Mail
            /// *   Elasticsearch: Elasticsearch
            /// *   EMR: E-MapReduce (EMR)
            /// *   ESS: Auto Scaling
            /// *   FunctionCompute: Function Compute
            /// *   RealtimeCompute: Realtime Compute for Apache Flink
            /// *   GlobalAcceleration: Global Accelerator (GA)
            /// *   Hbase: ApsaraDB for HBase
            /// *   TSDB: Time Series Database (TSDB)
            /// *   IPv6trans: IPv6 Translation Service
            /// *   Kafka: Message Queue for Apache Kafka
            /// *   Kubernetes: Container Service for Kubernetes (ACK)
            /// *   KVstore: ApsaraDB for Redis
            /// *   MNS: Message Service (MNS)
            /// *   MongoDB: ApsaraDB for MongoDB
            /// *   MQ: Message Queue
            /// *   NAT: NAT Gateway
            /// *   OpenAd: Open Ad
            /// *   OpenSearch: Open Search
            /// *   OSS: Object Storage Service (OSS)
            /// *   PCDN: P2P CDN
            /// *   petadata: HybridDB for MySQL
            /// *   RDS: ApsaraDB RDS
            /// *   SCDN: Secure CDN
            /// *   SLB: Server Load Balancer (SLB)
            /// *   SLS: Log Service
            /// *   VideoLive: ApsaraVideo Live
            /// *   VOD: ApsaraVideo VOD
            /// *   EIP: Elastic IP Address (EIP)
            /// *   VPN: VPN Gateway
            /// *   AIRec: Artificial Intelligence Recommendation
            /// *   GPDB: AnalyticDB for PostgreSQL
            /// *   DBS: Database Backup (DBS)
            /// *   SAG: Smart Access Gateway (SAG)
            /// *   Memcache: ApsaraDB for Memcache
            /// *   IOT_EDGE: Link IoT Edge
            /// *   OCS: ApsaraDB for Memcache (previous version)
            /// *   VPC: Express Connect
            /// *   EHPC: Elastic High Performance Computing (E-HPC)
            /// *   MPS: ApsaraVideo Media Processing
            /// *   ENS: Edge Node Service (ENS)
            /// *   MaxCompute_Prepay: MaxCompute
            /// *   IoT_Kubernetes: Edge Application Hosting
            /// *   CMS: CloudMonitor
            /// *   batchcomputenew: Batch Compute
            /// *   HBaseUE: ApsaraDB for HBase Performance-enhanced Edition
            /// *   UIS: Ultimate Internet Service (UIS)
            /// *   nls: Intelligent Speech Interaction
            /// *   ots: Tablestore
            /// *   NAS: Apsara File Storage NAS
            /// *   ECI: Elastic Container Instance (ECI)
            /// *   OpenAPI: OpenAPI Explorer
            /// *   pvtzpost: Alibaba Cloud DNS PrivateZone
            /// *   blinkonk8s: Flink on Kubernetes
            /// *   FunctionFlow: Serverless Workflow (SWF)
            /// *   SMC: Server Migration Center (SMC)
            /// *   ddosbgp: Anti-DDoS Origin
            /// *   baas: Blockchain as a Service
            /// *   privatelink: PrivateLink
            /// *   cds: ApsaraDB for Cassandra
            /// *   DDH: Dedicated Host
            /// *   RocketMQ: Message Queue for Apache RocketMQ
            /// *   ECC: Express Cloud Connect
            /// *   hbaseserverless: ApsaraDB for HBase Serverless Edition
            /// *   mns_tmp: Message Service
            /// *   hdr: Hybrid Disaster Recovery (HDR)
            /// *   hbr: Hybrid Backup Recovery (HBR)
            /// *   ADB: AnalyticDB for MySQL V3.0
            /// *   tag: Tag Service
            /// *   GDB: Graph Database
            /// *   WAF: Web Application Firewall (WAF)
            /// *   hcs_sgw: Cloud Storage Gateway (CSG)
            /// *   ipv6gateway: IPv6 Gateway
            /// *   RDS_SAR: ApsaraDB Exclusive Host Group
            /// *   learn: Machine Learning Platform for AI
            /// *   ROS: Resource Orchestration Service (ROS)
            /// *   OOS: Operation Orchestration Service (OOS)
            /// *   bds: Data Synchronization for HBase
            /// *   cfw: Cloud Firewall
            /// *   ddosDip: Anti-DDoS Premium
            /// *   datahub: DataHub
            /// *   hologres: Hologres
            /// *   ExpressConnect: Express Connect
            /// *   dbfs: Database File System (DBFS)
            /// *   clickhouse: ApsaraDB for ClickHouse
            /// *   k8s: Container Service for Kubernetes (ACK)
            /// *   DTS: Data Transmission Service (DTS)
            /// *   AnycastEIP: Anycast Elastic IP Address
            /// *   Lindorm: ApsaraDB for Lindorm
            /// *   config: Cloud Config
            /// *   spark: Databricks DataInsight (DDI)
            /// *   serverless: Serverless App Engine (SAE)
            /// *   alb: Application Load Balancer (ALB)
            /// *   oceanbase: ApsaraDB for OceanBase
            /// *   KMS: Key Management Service (KMS)
            /// *   lvwang: Content Moderation
            /// *   LinkVisual: LinkVisual
            /// *   tair: ApsaraDB for Redis Enhanced Edition (Tair)
            /// *   dlf: Data Lake Formation (DLF)
            /// *   networkmonitor: Site Monitoring
            /// *   pnc: Physical Network Change
            /// *   AIS: Alibaba Cloud Infrastructure
            /// *   cloudgame: Cloud Gaming Platform
            /// *   RTC: Real-Time Communication
            /// *   cloudbox: CloudBox
            /// *   actiontrail: ActionTrail
            /// *   cc: Cloud Connector
            /// *   disk: Elastic Block Storage (EBS)
            /// *   easygene: Genomics Computing Platform
            /// *   cloudphone: Elastic Cloud Phone
            /// *   BMS: Bare Metal Management Service
            /// *   swas: Simple Application Server
            /// *   AvailabilityMonitoring: Availability Monitoring of CloudMonitor
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The alert contact groups. Valid values of N: 1 to 200.
            /// 
            /// For information about how to obtain alert contact groups, see [DescribeContactGroupList](https://help.aliyun.com/document_detail/114922.html).
            /// </summary>
            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public string ContactGroups { get; set; }

            /// <summary>
            /// The dimension of the alert rule. Valid values of N: 1 to 200.
            /// 
            /// Set the value to a set of key-value pairs, for example, `userId:120886317861****` or `instanceId:i-m5e1qg6uo38rztr4****`.
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public string Dimensions { get; set; }

            /// <summary>
            /// The time period during which the alert rule is effective. Valid values of N: 1 to 200.
            /// </summary>
            [NameInMap("EffectiveInterval")]
            [Validation(Required=false)]
            public string EffectiveInterval { get; set; }

            /// <summary>
            /// The subject of the alert notification email. Valid values of N: 1 to 200.
            /// </summary>
            [NameInMap("EmailSubject")]
            [Validation(Required=false)]
            public string EmailSubject { get; set; }

            /// <summary>
            /// The interval at which CloudMonitor checks whether the alert rule is triggered. Valid values of N: 1 to 200.
            /// 
            /// Unit: seconds. The default value is the lowest frequency at which the metric is polled.
            /// 
            /// >  We recommend that you set the interval to the data aggregation period. If the interval is shorter than the data aggregation period, alerts cannot be triggered due to insufficient data.
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<CreateGroupMetricRulesRequestGroupMetricRulesLabels> Labels { get; set; }
            public class CreateGroupMetricRulesRequestGroupMetricRulesLabels : TeaModel {
                /// <summary>
                /// The tag key of the alert rule. The specified tag is contained in alert notifications.
                /// 
                /// Valid values of N: 1 to 200.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value of the alert rule. The specified tag is contained in alert notifications.
                /// 
                /// Valid values of N: 1 to 200.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The name of the metric. Valid values of N: 1 to 200.
            /// 
            /// For information about how to obtain the name of a metric, see [DescribeMetricMetaList](https://help.aliyun.com/document_detail/98846.html) or [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The namespace of the cloud service. Valid values of N: 1 to 200.
            /// 
            /// For information about how to obtain the namespace of a cloud service, see [DescribeMetricMetaList](https://help.aliyun.com/document_detail/98846.html) or [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The method that is used to handle alerts when no monitoring data is found. Valid values of N: 1 to 200. Valid value:
            /// 
            /// *   KEEP_LAST_STATE (default value): No operation is performed.
            /// *   INSUFFICIENT_DATA: An alert whose content is "Insufficient data" is triggered.
            /// *   OK: The alert rule has no active alerts.
            /// </summary>
            [NameInMap("NoDataPolicy")]
            [Validation(Required=false)]
            public string NoDataPolicy { get; set; }

            /// <summary>
            /// The time period during which the alert rule is ineffective. Valid values of N: 1 to 200.
            /// </summary>
            [NameInMap("NoEffectiveInterval")]
            [Validation(Required=false)]
            public string NoEffectiveInterval { get; set; }

            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }

            /// <summary>
            /// The aggregation period of the metric data. Valid values of N: 1 to 200.
            /// 
            /// Set the `Period` parameter to an integral multiple of 60. Unit: seconds. Default value: 300.
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// The ID of the alert rule. Valid values of N: 1 to 200.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// The name of the alert rule. Valid values of N: 1 to 200.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The mute period during which new alerts are not sent even if the trigger conditions are met. Valid values of N: 1 to 200.
            /// 
            /// Unit: seconds. Default value: 86400. Minimum value: 3600.
            /// </summary>
            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public int? SilenceTime { get; set; }

            /// <summary>
            /// The callback URL. Valid values of N: 1 to 200.
            /// 
            /// The callback URL must be accessible over the Internet. CloudMonitor pushes an alert notification to the specified callback URL by sending an HTTP POST request. Only the HTTP protocol is supported.
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
