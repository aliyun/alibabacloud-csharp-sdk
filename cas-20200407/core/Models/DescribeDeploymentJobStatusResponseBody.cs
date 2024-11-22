// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DescribeDeploymentJobStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of purchased resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("BuyCount")]
        [Validation(Required=false)]
        public int? BuyCount { get; set; }

        /// <summary>
        /// <para>The number of certificates involved in the deployment task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("CertCount")]
        [Validation(Required=false)]
        public int? CertCount { get; set; }

        /// <summary>
        /// <para>The number of resources consumed by worker tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("CostCount")]
        [Validation(Required=false)]
        public int? CostCount { get; set; }

        /// <summary>
        /// <para>The number of failed worker tasks, excluding rollback tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("FailedCount")]
        [Validation(Required=false)]
        public int? FailedCount { get; set; }

        /// <summary>
        /// <para>The total number of worker tasks that match the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MatchWorkerCount")]
        [Validation(Required=false)]
        public int? MatchWorkerCount { get; set; }

        /// <summary>
        /// <para>The number of cloud resources to which certificates are deployed in the deployment task.</para>
        /// </summary>
        [NameInMap("ProductWorkerCount")]
        [Validation(Required=false)]
        public List<DescribeDeploymentJobStatusResponseBodyProductWorkerCount> ProductWorkerCount { get; set; }
        public class DescribeDeploymentJobStatusResponseBodyProductWorkerCount : TeaModel {
            /// <summary>
            /// <para>The total number of resources of a cloud service in the deployment task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The name of the cloud service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SLB</b>: Classic Load Balancer (CLB). This value is supported only at the China site (aliyun.com).</description></item>
            /// <item><description><b>LIVE</b>: ApsaraVideo Live. This value is supported only at the China site (aliyun.com).</description></item>
            /// <item><description><b>webHosting</b>: Cloud Web Hosting. This value is supported only at the China site (aliyun.com).</description></item>
            /// <item><description><b>VOD</b>: ApsaraVideo VOD. This value is supported only at the China site (aliyun.com).</description></item>
            /// <item><description><b>CR</b>: Container Registry. This value is supported only at the China site (aliyun.com).</description></item>
            /// <item><description><b>DCDN</b>: Dynamic Content Delivery Network (DCDN).</description></item>
            /// <item><description><b>DDOS</b>: Anti-DDoS.</description></item>
            /// <item><description><b>CDN</b>: Alibaba Cloud CDN (CDN).</description></item>
            /// <item><description><b>ALB</b>: Application Load Balancer (ALB).</description></item>
            /// <item><description><b>APIGateway</b>: API Gateway.</description></item>
            /// <item><description><b>FC</b>: Function Compute.</description></item>
            /// <item><description><b>GA</b>: Global Accelerator (GA).</description></item>
            /// <item><description><b>MSE</b>: Microservices Engine (MSE).</description></item>
            /// <item><description><b>NLB</b>: Network Load Balancer (NLB).</description></item>
            /// <item><description><b>OSS</b>: Object Storage Service (OSS).</description></item>
            /// <item><description><b>SAE</b>: Serverless App Engine (SAE).</description></item>
            /// <item><description><b>TencentCDN</b>: Tencent Cloud Content Delivery Network (CDN).</description></item>
            /// <item><description><b>WAF</b>: Web Application Firewall (WAF).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NLB</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4127</para>
        /// </summary>
        [NameInMap("ResourceCount")]
        [Validation(Required=false)]
        public int? ResourceCount { get; set; }

        /// <summary>
        /// <para>The number of worker tasks that are rolled backed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("RollbackCount")]
        [Validation(Required=false)]
        public int? RollbackCount { get; set; }

        /// <summary>
        /// <para>The number of worker tasks that failed to be rolled back.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("RollbackFailedCount")]
        [Validation(Required=false)]
        public int? RollbackFailedCount { get; set; }

        /// <summary>
        /// <para>The number of worker tasks that are successfully rolled back.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("RollbackSuccessCount")]
        [Validation(Required=false)]
        public int? RollbackSuccessCount { get; set; }

        /// <summary>
        /// <para>The number of successful worker tasks, excluding rollback tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// <para>The total number of used resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("UseCount")]
        [Validation(Required=false)]
        public int? UseCount { get; set; }

        /// <summary>
        /// <para>The total number of resources to which certificate are deployed in the current cloud service. The value indicates the total number of worker tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("WorkerCount")]
        [Validation(Required=false)]
        public int? WorkerCount { get; set; }

    }

}
