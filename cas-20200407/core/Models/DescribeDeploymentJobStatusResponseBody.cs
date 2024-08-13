// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DescribeDeploymentJobStatusResponseBody : TeaModel {
        /// <summary>
        /// The total number of purchased resources.
        /// </summary>
        [NameInMap("BuyCount")]
        [Validation(Required=false)]
        public int? BuyCount { get; set; }

        /// <summary>
        /// The number of certificates involved in the deployment task.
        /// </summary>
        [NameInMap("CertCount")]
        [Validation(Required=false)]
        public int? CertCount { get; set; }

        /// <summary>
        /// The number of resources consumed by worker tasks.
        /// </summary>
        [NameInMap("CostCount")]
        [Validation(Required=false)]
        public int? CostCount { get; set; }

        /// <summary>
        /// The number of failed worker tasks, excluding rollback tasks.
        /// </summary>
        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public int? FailedCount { get; set; }

        /// <summary>
        /// The total number of worker tasks that match the certificate.
        /// </summary>
        [NameInMap("MatchWorkerCount")]
        [Validation(Required=false)]
        public int? MatchWorkerCount { get; set; }

        /// <summary>
        /// The number of cloud resources to which certificates are deployed in the deployment task.
        /// </summary>
        [NameInMap("ProductWorkerCount")]
        [Validation(Required=false)]
        public List<DescribeDeploymentJobStatusResponseBodyProductWorkerCount> ProductWorkerCount { get; set; }
        public class DescribeDeploymentJobStatusResponseBodyProductWorkerCount : TeaModel {
            /// <summary>
            /// The total number of resources of a cloud service in the deployment task.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The name of the cloud service. Valid values:
            /// 
            /// *   **SLB**: Classic Load Balancer (CLB). This value is supported only at the China site (aliyun.com).
            /// *   **LIVE**: ApsaraVideo Live. This value is supported only at the China site (aliyun.com).
            /// *   **webHosting**: Cloud Web Hosting. This value is supported only at the China site (aliyun.com).
            /// *   **VOD**: ApsaraVideo VOD. This value is supported only at the China site (aliyun.com).
            /// *   **CR**: Container Registry. This value is supported only at the China site (aliyun.com).
            /// *   **DCDN**: Dynamic Content Delivery Network (DCDN).
            /// *   **DDOS**: Anti-DDoS.
            /// *   **CDN**: Alibaba Cloud CDN (CDN).
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
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of resources.
        /// </summary>
        [NameInMap("ResourceCount")]
        [Validation(Required=false)]
        public int? ResourceCount { get; set; }

        /// <summary>
        /// The number of worker tasks that are rolled backed.
        /// </summary>
        [NameInMap("RollbackCount")]
        [Validation(Required=false)]
        public int? RollbackCount { get; set; }

        /// <summary>
        /// The number of worker tasks that failed to be rolled back.
        /// </summary>
        [NameInMap("RollbackFailedCount")]
        [Validation(Required=false)]
        public int? RollbackFailedCount { get; set; }

        /// <summary>
        /// The number of worker tasks that are successfully rolled back.
        /// </summary>
        [NameInMap("RollbackSuccessCount")]
        [Validation(Required=false)]
        public int? RollbackSuccessCount { get; set; }

        /// <summary>
        /// The number of successful worker tasks, excluding rollback tasks.
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// The total number of used resources.
        /// </summary>
        [NameInMap("UseCount")]
        [Validation(Required=false)]
        public int? UseCount { get; set; }

        /// <summary>
        /// The total number of resources to which certificate are deployed in the current cloud service. The value indicates the total number of worker tasks.
        /// </summary>
        [NameInMap("WorkerCount")]
        [Validation(Required=false)]
        public int? WorkerCount { get; set; }

    }

}
