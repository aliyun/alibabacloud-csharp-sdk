// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetServiceProvisionsRequest : TeaModel {
        /// <summary>
        /// <para>The parameters.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<GetServiceProvisionsRequestParameters> Parameters { get; set; }
        public class GetServiceProvisionsRequestParameters : TeaModel {
            /// <summary>
            /// <para>The name of the parameter. If you do not specify the name and value of a parameter, Resource Orchestration Service (ROS) uses the default name and value that are specified in the template.</para>
            /// <remarks>
            /// <para>The Parameters parameter is optional. If you specify Parameters, you must specify ParameterKey.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Amount</para>
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// <para>The value of the parameter.</para>
            /// <remarks>
            /// <para>The Parameters parameter is optional. If you specify Parameters, you must specify ParameterValue.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The services.</para>
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<GetServiceProvisionsRequestServices> Services { get; set; }
        public class GetServiceProvisionsRequestServices : TeaModel {
            /// <summary>
            /// <para>The name of the service or feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AHAS: Application High Availability Service</description></item>
            /// <item><description>ARMS: Application Real-Time Monitoring Service (ARMS)</description></item>
            /// <item><description>ApiGateway: API Gateway</description></item>
            /// <item><description>BatchCompute: Batch Compute</description></item>
            /// <item><description>BrainIndustrial: Industrial Brain</description></item>
            /// <item><description>CloudStorageGateway: Cloud Storage Gateway (CSG)</description></item>
            /// <item><description>CMS: CloudMonitor</description></item>
            /// <item><description>CR: Container Registry</description></item>
            /// <item><description>CS: Container Service for Kubernetes (ACK)</description></item>
            /// <item><description>DCDN: Dynamic Content Delivery Network (DCDN)</description></item>
            /// <item><description>DataHub: DataHub</description></item>
            /// <item><description>DataWorks: DataWorks</description></item>
            /// <item><description>EDAS: Enterprise Distributed Application Service (EDAS)</description></item>
            /// <item><description>EHPC: E-HPC</description></item>
            /// <item><description>EMAS: Enterprise Mobile Application Studio (EMAS)</description></item>
            /// <item><description>FC: Function Compute</description></item>
            /// <item><description>FNF: CloudFlow (SWF)</description></item>
            /// <item><description>MaxCompute: MaxCompute</description></item>
            /// <item><description>MNS: Message Service (MNS)</description></item>
            /// <item><description>HBR: Cloud Backup</description></item>
            /// <item><description>IMM: Intelligent Media Management (IMM)</description></item>
            /// <item><description>IOT: IoT Platform</description></item>
            /// <item><description>KMS: Key Management Service (KMS)</description></item>
            /// <item><description>NAS: File Storage NAS (NAS)</description></item>
            /// <item><description>NLP: Natural Language Processing (NLP)</description></item>
            /// <item><description>OSS: Object Storage Service (OSS)</description></item>
            /// <item><description>OTS: Tablestore</description></item>
            /// <item><description>PrivateLink: PrivateLink</description></item>
            /// <item><description>PrivateZone: Alibaba Cloud DNS PrivateZone</description></item>
            /// <item><description>RocketMQ: ApsaraMQ for RocketMQ</description></item>
            /// <item><description>SAE: Serverless App Engine (SAE)</description></item>
            /// <item><description>SLS: Simple Log Service (SLS)</description></item>
            /// <item><description>TrafficMirror: traffic mirroring</description></item>
            /// <item><description>VS: Video Surveillance System</description></item>
            /// <item><description>Xtrace: Managed Service for OpenTelemetry</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EHPC</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The template ID. This parameter applies to shared and private templates.</para>
        /// <para>You must and can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, and Services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an Object Storage Service (OSS) bucket, such as oss://ros/template/demo or oss://ros/template/demo?RegionId=cn-hangzhou. The template body must be 1 to 524,288 bytes in length. If you do not specify the region ID of the OSS bucket, the value of RegionId is used.</para>
        /// <para>You must and can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, and Services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros-template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The version of the template. If you do not specify this parameter, the latest version is used.</para>
        /// <para>This parameter takes effect only when TemplateId is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
