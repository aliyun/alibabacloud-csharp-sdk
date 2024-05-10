// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetServiceProvisionsRequest : TeaModel {
        /// <summary>
        /// The parameters.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<GetServiceProvisionsRequestParameters> Parameters { get; set; }
        public class GetServiceProvisionsRequestParameters : TeaModel {
            /// <summary>
            /// The name of the parameter. If you do not specify the name and value of a parameter, Resource Orchestration Service (ROS) uses the default name and value that are specified in the template.
            /// 
            /// > The Parameters parameter is optional. If you specify Parameters, you must specify ParameterKey.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The value of the parameter.
            /// 
            /// > The Parameters parameter is optional. If you specify Parameters, you must specify ParameterValue.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/131035.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The services.
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<GetServiceProvisionsRequestServices> Services { get; set; }
        public class GetServiceProvisionsRequestServices : TeaModel {
            /// <summary>
            /// The service or feature name. Valid values:
            /// 
            /// *   AHAS: Application High Availability Service
            /// *   ARMS: Application Real-Time Monitoring Service (ARMS)
            /// *   ApiGateway: API Gateway
            /// *   BatchCompute: Batch Compute
            /// *   BrainIndustrial: Industrial Brain
            /// *   CloudStorageGateway: Cloud Storage Gateway (CSG)
            /// *   CMS: CloudMonitor
            /// *   CR: Container Registry
            /// *   CS: Container Service for Kubernetes (ACK)
            /// *   DCDN: Dynamic Content Delivery Network (DCDN)
            /// *   DataHub: DataHub
            /// *   DataWorks: DataWorks
            /// *   EDAS: Enterprise Distributed Application Service (EDAS)
            /// *   EHPC: Elastic High Performance Computing (E-HPC)
            /// *   EMAS: Enterprise Mobile Application Studio (EMAS)
            /// *   FC: Function Compute
            /// *   FNF: Serverless Workflow (SWF)
            /// *   MaxCompute: MaxCompute
            /// *   MNS: Message Service (MNS)
            /// *   HBR: Hybrid Backup Recovery (HBR)
            /// *   IMM: Intelligent Media Management
            /// *   IOT: IoT Platform
            /// *   KMS: Key Management Service (KMS)
            /// *   NAS: Apsara File Storage NAS (NAS)
            /// *   NLP: Natural Language Processing (NLP)
            /// *   OSS: OSS
            /// *   OTS: Tablestore
            /// *   PrivateLink: PrivateLink
            /// *   PrivateZone: Alibaba Cloud DNS PrivateZone
            /// *   RocketMQ: ApsaraMQ for RocketMQ
            /// *   SAE: Serverless App Engine (SAE)
            /// *   SLS: Log Service
            /// *   TrafficMirror: the traffic mirroring feature
            /// *   VS: Video Surveillance System
            /// *   Xtrace: Managed Service for OpenTelemetry
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// The template ID. This parameter applies to shared and private templates.
        /// 
        /// You must and can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, and Services.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an Object Storage Service (OSS) bucket, such as oss://ros/template/demo or oss://ros/template/demo?RegionId=cn-hangzhou. The template body must be 1 to 524,288 bytes in length. If you do not specify the region ID of the OSS bucket, the value of RegionId is used.
        /// 
        /// You must and can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, and Services.
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// The version of the template. If you do not specify this parameter, the latest version is used.
        /// 
        /// This parameter takes effect only when TemplateId is specified.
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
