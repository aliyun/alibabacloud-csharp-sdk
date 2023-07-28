// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutGroupMetricRuleRequest : TeaModel {
        [NameInMap("Escalations")]
        [Validation(Required=false)]
        public PutGroupMetricRuleRequestEscalations Escalations { get; set; }
        public class PutGroupMetricRuleRequestEscalations : TeaModel {
            [NameInMap("Critical")]
            [Validation(Required=false)]
            public PutGroupMetricRuleRequestEscalationsCritical Critical { get; set; }
            public class PutGroupMetricRuleRequestEscalationsCritical : TeaModel {
                /// <summary>
                /// The consecutive number of times for which the metric value meets the alert condition before a Warn-level alert is triggered.
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// The interval at which the alert rule is executed. Unit: seconds.
                /// 
                /// >  We recommend that you set the interval to the data aggregation period. If the interval is shorter than the data aggregation period, alerts cannot be triggered due to insufficient data.
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// The name of the cloud service. Valid values:
                /// 
                /// *   PolarDB: PolarDB
                /// *   NewBGPDDoS: Anti-DDoS Pro
                /// *   IoTDevice: IoT Platform
                /// *   DRDS: PolarDB-X
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
                /// *   AIRec: Artificial Intelligence Recommendation (AIRec)
                /// *   GPDB: AnalyticDB for PostgreSQL
                /// *   DBS: Database Backup (DBS)
                /// *   SAG: Smart Access Gateway (SAG)
                /// *   Memcache: ApsaraDB for Memcache
                /// *   IOT_EDGE: Link IoT Edge
                /// *   OCS: ApsaraDB for Memcache (previous version)
                /// *   VPC: Express Connect
                /// *   EHPC: Elastic High Performance Computing (E-HPC)
                /// *   MPS: ApsaraVideo Media Processing (MPS)
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
                /// *   ECC: Express Cloud Connect (ECC)
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
                /// *   Lindorm: Lindorm
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
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// The first-level dimension of the alert rule in the application group.
                /// 
                /// Set the value to a set of key-value pairs, for example, `userId:120886317861****` or `instanceId:i-m5e1qg6uo38rztr4****`.
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public int? Times { get; set; }

            }

            [NameInMap("Info")]
            [Validation(Required=false)]
            public PutGroupMetricRuleRequestEscalationsInfo Info { get; set; }
            public class PutGroupMetricRuleRequestEscalationsInfo : TeaModel {
                /// <summary>
                /// The time period during which the alert rule is effective.
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// The mute period during which new alerts are not sent even if the trigger conditions are met.
                /// 
                /// Unit: seconds. Default value: 86400.
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// The alert contact group.
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// The statistical methods for Critical-level alerts. Separate multiple statistical methods with commas (,). Valid values:
                /// 
                /// *   Average: the average value
                /// *   Minimum: the minimum value
                /// *   Maximum: the maximum value
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public int? Times { get; set; }

            }

            [NameInMap("Warn")]
            [Validation(Required=false)]
            public PutGroupMetricRuleRequestEscalationsWarn Warn { get; set; }
            public class PutGroupMetricRuleRequestEscalationsWarn : TeaModel {
                /// <summary>
                /// The tag value of the alert rule.
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// The comparison operator that is used to compare the metric value with the threshold. Valid values:
                /// 
                /// *   GreaterThanOrEqualToThreshold: greater than or equal to the threshold
                /// *   GreaterThanThreshold: greater than the threshold
                /// *   LessThanOrEqualToThreshold: less than or equal to the threshold
                /// *   LessThanThreshold: less than the threshold
                /// *   NotEqualToThreshold: not equal to the threshold
                /// *   GreaterThanYesterday: greater than the metric value at the same time yesterday
                /// *   LessThanYesterday: less than the metric value at the same time yesterday
                /// *   GreaterThanLastWeek: greater than the metric value at the same time last week
                /// *   LessThanLastWeek: less than the metric value at the same time last week
                /// *   GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle
                /// *   LessThanLastPeriod: less than the metric value in the last monitoring cycle
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// The method that is used to handle alerts when no monitoring data is found. Valid values:
                /// 
                /// *   KEEP_LAST_STATE (default value): No operation is performed.
                /// *   INSUFFICIENT_DATA: An alert whose content is "Insufficient data" is triggered.
                /// *   OK: The status is considered normal.
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                /// <summary>
                /// The tag key of the alert rule.
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public int? Times { get; set; }

            }

        }

        /// <summary>
        /// The operation that you want to perform. Set the value to **PutGroupMetricRule**.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The ID of the alert rule.
        /// 
        /// *   When you create an alert rule for the application group, enter the ID of the alert rule.
        /// *   When you modify a specified alert rule in the application group, you must obtain the ID of the alert rule. For information about how to obtain the ID of an alert rule, see [DescribeMetricRuleList](~~114941~~).
        /// </summary>
        [NameInMap("ContactGroups")]
        [Validation(Required=false)]
        public string ContactGroups { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// The ID of the application group.
        /// 
        /// For information about how to obtain the ID of an application group, see [DescribeMonitorGroups](~~115032~~).
        /// </summary>
        [NameInMap("EffectiveInterval")]
        [Validation(Required=false)]
        public string EffectiveInterval { get; set; }

        /// <summary>
        /// The second-level or third-level dimension of the alert rule in the application group.
        /// 
        /// Set the value to a set of key-value pairs, for example, `port:80` or `/dev/xvda:d-m5e6yphgzn3aprwu****`.
        /// 
        /// If the first-level dimension of the alert rule is `instanceId:i-m5e1qg6uo38rztr4****`, its second-level dimension is the `/dev/xvda:d-m5e6yphgzn3aprwu****` disk in the instance.
        /// </summary>
        [NameInMap("EmailSubject")]
        [Validation(Required=false)]
        public string EmailSubject { get; set; }

        /// <summary>
        /// The name of the metric.
        /// 
        /// For information about how to obtain the name of a metric, see [DescribeMetricMetaList](~~98846~~) or [Appendix 1: Metrics](~~163515~~).
        /// </summary>
        [NameInMap("ExtraDimensionJson")]
        [Validation(Required=false)]
        public string ExtraDimensionJson { get; set; }

        /// <summary>
        /// The statistical methods for Warn-level alerts. Separate multiple statistical methods with commas (,). Valid values:
        /// 
        /// *   Average: the average value
        /// *   Minimum: the minimum value
        /// *   Maximum: the maximum value
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The callback URL.
        /// 
        /// The callback URL must be accessible over the Internet. CloudMonitor sends a POST request to push an alert notification to the callback URL that you specify. Only HTTP requests are supported.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<PutGroupMetricRuleRequestLabels> Labels { get; set; }
        public class PutGroupMetricRuleRequestLabels : TeaModel {
            /// <summary>
            /// The name of the alert rule.
            /// 
            /// *   When you create an alert rule for the application group, enter the name of the alert rule.
            /// *   When you modify a specified alert rule in the application group, you must obtain the name of the alert rule. For information about how to obtain the name of an alert rule, see [DescribeMetricRuleList](~~114941~~).
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The ID of the alert rule.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The comparison operator that is used to compare the metric value with the threshold. Valid values:
        /// 
        /// *   GreaterThanOrEqualToThreshold: greater than or equal to the threshold
        /// *   GreaterThanThreshold: greater than the threshold
        /// *   LessThanOrEqualToThreshold: less than or equal to the threshold
        /// *   LessThanThreshold: less than the threshold
        /// *   NotEqualToThreshold: not equal to the threshold
        /// *   GreaterThanYesterday: greater than the metric value at the same time yesterday
        /// *   LessThanYesterday: less than the metric value at the same time yesterday
        /// *   GreaterThanLastWeek: greater than the metric value at the same time last week
        /// *   LessThanLastWeek: less than the metric value at the same time last week
        /// *   GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle
        /// *   LessThanLastPeriod: less than the metric value in the last monitoring cycle
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The threshold for Critical-level alerts.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The consecutive number of times for which the metric value meets the alert condition before a Critical-level alert is triggered.
        /// </summary>
        [NameInMap("NoDataPolicy")]
        [Validation(Required=false)]
        public string NoDataPolicy { get; set; }

        /// <summary>
        /// The threshold for Info-level alerts.
        /// </summary>
        [NameInMap("NoEffectiveInterval")]
        [Validation(Required=false)]
        public string NoEffectiveInterval { get; set; }

        /// <summary>
        /// The threshold for Warn-level alerts.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// The namespace of the cloud service.
        /// 
        /// For information about how to obtain the namespace of a cloud service, see [DescribeMetricMetaList](~~98846~~) or [Appendix 1: Metrics](~~163515~~).
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The consecutive number of times for which the metric value meets the alert condition before an Info-level alert is triggered.
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public int? SilenceTime { get; set; }

        /// <summary>
        /// The aggregation period of the metric data.
        /// 
        /// Set the `Period` parameter to an integral multiple of 60. Unit: seconds. Default value: 300.
        /// </summary>
        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}
