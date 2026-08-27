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
            /// <para>Parameters is optional. If you specify Parameters, you must specify ParameterKey.</para>
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
            /// <para>Parameters is optional. If you specify Parameters, you must specify ParameterValue.</para>
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
        /// <para>The list of Alibaba Cloud services.</para>
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<GetServiceProvisionsRequestServices> Services { get; set; }
        public class GetServiceProvisionsRequestServices : TeaModel {
            /// <summary>
            /// <para>The name of the Alibaba Cloud service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>AHAS: Application High Availability Service.</para>
            /// </description></item>
            /// <item><description><para>ARMS: Application Real-Time Monitoring Service.</para>
            /// </description></item>
            /// <item><description><para>ApiGateway: API Gateway.</para>
            /// </description></item>
            /// <item><description><para>BatchCompute: Batch Compute.</para>
            /// </description></item>
            /// <item><description><para>BrainIndustrial: Industrial Intelligence.</para>
            /// </description></item>
            /// <item><description><para>CloudStorageGateway: Cloud Storage Gateway.</para>
            /// </description></item>
            /// <item><description><para>CMS: Cloud Monitor.</para>
            /// </description></item>
            /// <item><description><para>CR: Container Registry.</para>
            /// </description></item>
            /// <item><description><para>CS: Container Service.</para>
            /// </description></item>
            /// <item><description><para>DCDN: DCDN.</para>
            /// </description></item>
            /// <item><description><para>DataHub: DataHub.</para>
            /// </description></item>
            /// <item><description><para>DataWorks: DataWorks.</para>
            /// </description></item>
            /// <item><description><para>EDAS: Enterprise Distributed Application Service.</para>
            /// </description></item>
            /// <item><description><para>EHPC: Elastic High Performance Computing.</para>
            /// </description></item>
            /// <item><description><para>EMAS: Enterprise Mobile Application Studio.</para>
            /// </description></item>
            /// <item><description><para>FC: Function Compute.</para>
            /// </description></item>
            /// <item><description><para>FNF: CloudFlow.</para>
            /// </description></item>
            /// <item><description><para>MaxCompute: MaxCompute.</para>
            /// </description></item>
            /// <item><description><para>SMQ: Simple Message Queue (formerly MNS).</para>
            /// </description></item>
            /// <item><description><para>HBR: Cloud Backup.</para>
            /// </description></item>
            /// <item><description><para>IMM: Intelligent Media Management.</para>
            /// </description></item>
            /// <item><description><para>IOT: IoT Platform.</para>
            /// </description></item>
            /// <item><description><para>KMS: Key Management Service.</para>
            /// </description></item>
            /// <item><description><para>NAS: File Storage NAS.</para>
            /// </description></item>
            /// <item><description><para>NLP: Natural Language Processing.</para>
            /// </description></item>
            /// <item><description><para>OSS: Object Storage Service.</para>
            /// </description></item>
            /// <item><description><para>OTS: Tablestore.</para>
            /// </description></item>
            /// <item><description><para>PrivateLink: PrivateLink.</para>
            /// </description></item>
            /// <item><description><para>PrivateZone: PrivateZone.</para>
            /// </description></item>
            /// <item><description><para>RocketMQ: Message Queue for Apache RocketMQ.</para>
            /// </description></item>
            /// <item><description><para>SAE: Serverless App Engine.</para>
            /// </description></item>
            /// <item><description><para>SLS: Simple Log Service.</para>
            /// </description></item>
            /// <item><description><para>TrafficMirror: Traffic Mirroring.</para>
            /// </description></item>
            /// <item><description><para>VS: Video Surveillance.</para>
            /// </description></item>
            /// <item><description><para>Xtrace: Tracing Analysis.</para>
            /// </description></item>
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

        /// <summary>
        /// <para>The structure of the template body. The template body must be 1 to 524,288 bytes in length. If the length of the template body exceeds the upper limit, we recommend to use the HTTP POST + Body Param method to pass the parameter in the request body to avoid request failures caused by an excessively long URL.</para>
        /// <remarks>
        /// <para>You can specify only one of the TemplateBody, TemplateURL, TemplateId, and Services parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ROSTemplateFormatVersion: \&quot;2015-09-01\&quot;\r\nResources:\r\n  Vpc:\r\n    Type: ALIYUN::ECS::VPC\r\n    Properties:\r\n      CidrBlock: 192.168.0.0/24\r\n      VpcName: TestVpc</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The template ID. This parameter applies to shared and private templates.</para>
        /// <para>You can specify only one of the TemplateBody, TemplateURL, TemplateId, and Services parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an Object Storage Service (OSS) bucket. The template body must be 1 to 524,288 bytes in length. Examples of OSS URLs: oss\://ros/template/demo and oss\://ros/template/demo?RegionId=cn-hangzhou. If you do not specify the region ID of the OSS bucket, the value of the RegionId parameter is used.</para>
        /// <para>You can specify only one of the TemplateBody, TemplateURL, TemplateId, and Services parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros-template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The version of the template. If you do not specify this parameter, the latest version is used.</para>
        /// <para>This parameter takes effect only when you specify TemplateId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
