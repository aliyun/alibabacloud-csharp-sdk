// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyMetricRuleTemplateRequest : TeaModel {
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
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public int? N { get; set; }

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
                public ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsInfo Info { get; set; }
                public class ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsInfo : TeaModel {
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public int? N { get; set; }

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
                public ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsWarn Warn { get; set; }
                public class ModifyMetricRuleTemplateRequestAlertTemplatesEscalationsWarn : TeaModel {
                    [NameInMap("ComparisonOperator")]
                    [Validation(Required=false)]
                    public string ComparisonOperator { get; set; }

                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public int? N { get; set; }

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
            /// The statistical period of monitoring data. Valid values of N: 1 to 200.
            /// 
            /// >  If the value is set to 300 seconds, the monitoring data is collected every 300 seconds. If the monitoring data is reported every 1 minute, the alert system calculates the average, maximum, and minimum values of the monitoring data of 5 minutes and checks whether the aggregated values exceed the threshold. To prevent unexpected alerts, we recommend that you set this parameter together with other parameters.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The operation that you want to perform. Set the value to ModifyMetricRuleTemplate.
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The ID of the alert template.
            /// 
            /// For information about how to obtain the ID of an alert template, see [DescribeMetricRuleTemplateList](~~114982~~).
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The dimension of the alert. It is an extended field. Valid values of N: 1 to 200.
            /// 
            /// For example, an alert template is applied to an application group, this parameter is set to `{"disk":"/"}`, and the MetricName parameter is set to `DiskUtilization`. In this case, the generated alert rule is applied to the root disk partition (`"/"`) of all instances in the application group to which the alert template is applied.
            /// 
            /// >  For more information about the values of extended fields, see [DescribeMetricRuleTemplateAttribute](~~114979~~).
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// The namespace of the cloud service. Valid values of N: 1 to 200.
            /// 
            /// For information about how to obtain the namespace of a cloud service, see [DescribeMetricMetaList](~~98846~~) or [Appendix 1: Metrics](~~163515~~).
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The abbreviation of the service name. Valid values of N: 1 to 200. Valid values:
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
            /// </summary>
            [NameInMap("Selector")]
            [Validation(Required=false)]
            public string Selector { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

        /// <summary>
        /// The description of the alert template.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the alert rule. Valid values of N: 1 to 200.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("RestVersion")]
        [Validation(Required=false)]
        public long? RestVersion { get; set; }

        /// <summary>
        /// The callback URL. Valid values of N: 1 to 200.
        /// 
        /// The callback URL must be accessible over the Internet. CloudMonitor sends a POST request to push an alert notification to the callback URL that you specify. Only HTTP requests are supported.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
