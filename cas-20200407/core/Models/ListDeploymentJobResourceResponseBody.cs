// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListDeploymentJobResourceResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDeploymentJobResourceResponseBodyData> Data { get; set; }
        public class ListDeploymentJobResourceResponseBodyData : TeaModel {
            /// <summary>
            /// The end date of the certificate bound to the cloud resource. The value is a timestamp in seconds.
            /// </summary>
            [NameInMap("CertEndTime")]
            [Validation(Required=false)]
            public string CertEndTime { get; set; }

            /// <summary>
            /// The ID of the certificate bound to the cloud resource.
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public long? CertId { get; set; }

            /// <summary>
            /// The name of the certificate bound to the cloud resource.
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// The start date of the certificate bound to the cloud resource. The value is a timestamp in seconds.
            /// </summary>
            [NameInMap("CertStartTime")]
            [Validation(Required=false)]
            public string CertStartTime { get; set; }

            /// <summary>
            /// The AccessKey ID used to access cloud resources.
            /// 
            /// >  This parameter is required only when you deploy certificates to services of multiple clouds.
            /// </summary>
            [NameInMap("CloudAccessId")]
            [Validation(Required=false)]
            public string CloudAccessId { get; set; }

            /// <summary>
            /// The cloud service provider of the cloud resource. Valid values:
            /// 
            /// *   **aliyun**: Alibaba Cloud
            /// *   **Tencent**: Tencent Cloud
            /// </summary>
            [NameInMap("CloudName")]
            [Validation(Required=false)]
            public string CloudName { get; set; }

            /// <summary>
            /// The cloud service. Valid values:
            /// 
            /// *   **CDN**: Alibaba Cloud CDN (CDN). This value is supported only at the China site (aliyun.com).
            /// *   **SLB**: Classic Load Balancer (CLB). This value is supported only at the China site (aliyun.com).
            /// *   **DCDN**: Dynamic Content Delivery Network (DCDN). This value is supported only at the China site (aliyun.com).
            /// *   **DDOS**: Anti-DDoS. This value is supported only at the China site (aliyun.com).
            /// *   **LIVE**: ApsaraVideo Live. This value is supported only at the China site (aliyun.com).
            /// *   **webHosting**: Cloud Web Hosting. This value is supported only at the China site (aliyun.com).
            /// *   **VOD**: ApsaraVideo VOD. This value is supported only at the China site (aliyun.com).
            /// *   **CR**: Container Registry. This value is supported only at the China site (aliyun.com).
            /// *   **ALB**: Application Load Balancer (ALB).
            /// *   **APIGateway**: API Gateway.
            /// *   **FC**: Function Compute.
            /// *   **GA**: Global Accelerator (GA).
            /// *   **MSE**: Microservices Engine (MSE).
            /// *   **NLB**: Network Load Balancer (NLB).
            /// *   **OSS**: Object Storage Service (OSS).
            /// *   **SAE**: Serverless App Engine (SAE).
            /// *   **TencentCDN**: Tencent Cloud Content Delivery Network (CDN).
            /// *   **WAF**: Web Application Firewall (WAF).
            /// </summary>
            [NameInMap("CloudProduct")]
            [Validation(Required=false)]
            public string CloudProduct { get; set; }

            /// <summary>
            /// The region ID of the cloud service provider to which the cloud resource belongs.
            /// </summary>
            [NameInMap("CloudRegion")]
            [Validation(Required=false)]
            public string CloudRegion { get; set; }

            /// <summary>
            /// Indicates whether the cloud resource is the default resource. Valid values:
            /// 
            /// *   **1**: yes
            /// *   **0**: no
            /// 
            /// >  This parameter is returned only when the value of CloudProduct is SLB, NLB, ALB, or GA.
            /// </summary>
            [NameInMap("DefaultResource")]
            [Validation(Required=false)]
            public int? DefaultResource { get; set; }

            /// <summary>
            /// The domain name bound to the cloud resource.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// Indicates whether HTTPS is enabled for the cloud resource. Valid values:
            /// 
            /// *   **1**: yes
            /// *   **0**: no
            /// </summary>
            [NameInMap("EnableHttps")]
            [Validation(Required=false)]
            public int? EnableHttps { get; set; }

            /// <summary>
            /// The time when the cloud resource was created. The time is a timestamp in seconds.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The time when the cloud resource was last modified. The time is in the timestamp format.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The ID of the cloud resource.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The instance ID of the cloud resource.
            /// 
            /// >  This parameter is returned only when the value of CloudProduct is SLB, NLB, ALB, or GA.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The listener ID of the cloud resource.
            /// 
            /// >  This parameter is returned only when the value of CloudProduct is SLB, NLB, ALB, or GA.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The listening port of the cloud resource.
            /// 
            /// >  This parameter is returned only when the value of CloudProduct is SLB, NLB, ALB, or GA.
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public string ListenerPort { get; set; }

            /// <summary>
            /// The region ID of the cloud resource.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The other metadata related to the cloud resource.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// The status of the cloud resource.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// Indicates whether an Alibaba Cloud SSL certificate is used. Valid values:
            /// 
            /// *   **1**: yes
            /// *   **0**: no
            /// 
            /// >  This parameter is required only when you deploy certificates to services of multiple clouds.
            /// </summary>
            [NameInMap("UseSsl")]
            [Validation(Required=false)]
            public int? UseSsl { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
