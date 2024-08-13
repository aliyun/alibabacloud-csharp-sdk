// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListWorkerResourceResponseBody : TeaModel {
        /// <summary>
        /// The page number. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListWorkerResourceResponseBodyData> Data { get; set; }
        public class ListWorkerResourceResponseBodyData : TeaModel {
            /// <summary>
            /// The domain name bound to the certificate in the worker task.
            /// </summary>
            [NameInMap("CertDomain")]
            [Validation(Required=false)]
            public string CertDomain { get; set; }

            /// <summary>
            /// The ID of the certificate in the worker task.
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public long? CertId { get; set; }

            /// <summary>
            /// The instance ID of the certificate in the worker task.
            /// </summary>
            [NameInMap("CertInstanceId")]
            [Validation(Required=false)]
            public string CertInstanceId { get; set; }

            /// <summary>
            /// The name of the certificate in the worker task.
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// The cloud service provider to which the cloud resource in the worker task belongs.
            /// 
            /// >  This parameter is not returned if you deploy certificates to Alibaba Cloud services.
            /// </summary>
            [NameInMap("CloudName")]
            [Validation(Required=false)]
            public string CloudName { get; set; }

            /// <summary>
            /// The cloud service to which the cloud resource in the worker task belongs. Valid values:
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
            /// The original region ID of the cloud resource in the worker task. The value is the region ID defined by the cloud service provider. This parameter is required only when you deploy certificates to services of multiple clouds.
            /// </summary>
            [NameInMap("CloudRegion")]
            [Validation(Required=false)]
            public string CloudRegion { get; set; }

            /// <summary>
            /// Indicates whether the cloud resource in the worker task is the default resource. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// >  This parameter is returned only when the value of CloudProduct is SLB, NLB, ALB, or GA.
            /// </summary>
            [NameInMap("DefaultResource")]
            [Validation(Required=false)]
            public bool? DefaultResource { get; set; }

            /// <summary>
            /// The time when the worker task was created. The time is a timestamp in seconds.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The time when the worker task was last modified. The time is a timestamp in seconds.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The ID of the worker task.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The ID of the cloud resource in the worker task.
            /// 
            /// >  This parameter is returned only when the value of CloudProduct is SLB, NLB, ALB, or GA.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The ID of the deployment task to which the worker task belongs.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

            /// <summary>
            /// The listener ID of the cloud resource in the worker task.
            /// 
            /// >  This parameter is returned only when the value of CloudProduct is SLB, NLB, ALB, or GA.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The ID of the namespace in SAE. This parameter is returned only if you deploy certificates to SAE.
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// The order ID of the worker task, which is the same as the order ID of the certificate.
            /// 
            /// >  If the CertId parameter is returned, this parameter is not returned.
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// The listening port of the cloud resource in the worker task.
            /// 
            /// >  This parameter is returned only when the value of CloudProduct is SLB, NLB, ALB, or GA.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The region ID of the cloud resource in the worker task.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the certificate that was originally bound to the cloud resource in the worker task.
            /// </summary>
            [NameInMap("ResourceCertId")]
            [Validation(Required=false)]
            public long? ResourceCertId { get; set; }

            /// <summary>
            /// The domain name that was originally bound to the cloud resource in the worker task.
            /// </summary>
            [NameInMap("ResourceDomain")]
            [Validation(Required=false)]
            public string ResourceDomain { get; set; }

            /// <summary>
            /// The ID of the cloud resource in the worker task.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public long? ResourceId { get; set; }

            /// <summary>
            /// The status of the worker task. Valid values:
            /// 
            /// *   **editing**
            /// *   **pending**
            /// *   **scheduling**
            /// *   **processing**
            /// *   **error**
            /// *   **success**
            /// *   **rollback**
            /// *   **rollback_success**
            /// *   **rollback_error**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the worker task belongs.
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

        /// <summary>
        /// The number of entries per page. Default value: **50**.
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
