// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListWorkerResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListWorkerResourceResponseBodyData> Data { get; set; }
        public class ListWorkerResourceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The domain name bound to the certificate in the worker task.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("CertDomain")]
            [Validation(Required=false)]
            public string CertDomain { get; set; }

            /// <summary>
            /// <para>The ID of the certificate in the worker task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12073663</para>
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public long? CertId { get; set; }

            /// <summary>
            /// <para>The instance ID of the certificate in the worker task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsn-jzk2h0xz5dmynuphb8@1883</para>
            /// </summary>
            [NameInMap("CertInstanceId")]
            [Validation(Required=false)]
            public string CertInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the certificate in the worker task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testCertName</para>
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>The cloud service provider to which the cloud resource in the worker task belongs.</para>
            /// <remarks>
            /// <para> This parameter is not returned if you deploy certificates to Alibaba Cloud services.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun</para>
            /// </summary>
            [NameInMap("CloudName")]
            [Validation(Required=false)]
            public string CloudName { get; set; }

            /// <summary>
            /// <para>The cloud service to which the cloud resource in the worker task belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>CDN</b>: Alibaba Cloud CDN (CDN). This value is supported only at the China site (aliyun.com).</description></item>
            /// <item><description><b>SLB</b>: Classic Load Balancer (CLB). This value is supported only at the China site (aliyun.com).</description></item>
            /// <item><description><b>DCDN</b>: Dynamic Content Delivery Network (DCDN). This value is supported only at the China site (aliyun.com).</description></item>
            /// <item><description><b>DDOS</b>: Anti-DDoS. This value is supported only at the China site (aliyun.com).</description></item>
            /// <item><description><b>LIVE</b>: ApsaraVideo Live. This value is supported only at the China site (aliyun.com).</description></item>
            /// <item><description><b>webHosting</b>: Cloud Web Hosting. This value is supported only at the China site (aliyun.com).</description></item>
            /// <item><description><b>VOD</b>: ApsaraVideo VOD. This value is supported only at the China site (aliyun.com).</description></item>
            /// <item><description><b>CR</b>: Container Registry. This value is supported only at the China site (aliyun.com).</description></item>
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
            /// <para>SLB</para>
            /// </summary>
            [NameInMap("CloudProduct")]
            [Validation(Required=false)]
            public string CloudProduct { get; set; }

            /// <summary>
            /// <para>The original region ID of the cloud resource in the worker task. The value is the region ID defined by the cloud service provider. This parameter is required only when you deploy certificates to services of multiple clouds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("CloudRegion")]
            [Validation(Required=false)]
            public string CloudRegion { get; set; }

            /// <summary>
            /// <para>Indicates whether the cloud resource in the worker task is the default resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is returned only when the value of CloudProduct is SLB, NLB, ALB, or GA.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DefaultResource")]
            [Validation(Required=false)]
            public bool? DefaultResource { get; set; }

            /// <summary>
            /// <para>The time when the worker task was created. The time is a timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1680228896000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the worker task was last modified. The time is a timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1681956830000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the worker task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22487</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The ID of the cloud resource in the worker task.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the value of CloudProduct is SLB, NLB, ALB, or GA.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cas-cn-0pp118nuu40b</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the deployment task to which the worker task belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8888</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

            /// <summary>
            /// <para>The listener ID of the cloud resource in the worker task.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the value of CloudProduct is SLB, NLB, ALB, or GA.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>lsn-lhl8y7s1e1ngc3m3zz@81</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The ID of the namespace in SAE. This parameter is returned only if you deploy certificates to SAE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32fed52a-4bf7-44f6-955f-e82ada68ef18</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The order ID of the worker task, which is the same as the order ID of the certificate.</para>
            /// <remarks>
            /// <para> If the CertId parameter is returned, this parameter is not returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>9349278</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>The listening port of the cloud resource in the worker task.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the value of CloudProduct is SLB, NLB, ALB, or GA.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>4431</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The region ID of the cloud resource in the worker task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the certificate that was originally bound to the cloud resource in the worker task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("ResourceCertId")]
            [Validation(Required=false)]
            public long? ResourceCertId { get; set; }

            /// <summary>
            /// <para>The domain name that was originally bound to the cloud resource in the worker task.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("ResourceDomain")]
            [Validation(Required=false)]
            public string ResourceDomain { get; set; }

            /// <summary>
            /// <para>The ID of the cloud resource in the worker task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1286999</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public long? ResourceId { get; set; }

            /// <summary>
            /// <para>The status of the worker task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>editing</b></description></item>
            /// <item><description><b>pending</b></description></item>
            /// <item><description><b>scheduling</b></description></item>
            /// <item><description><b>processing</b></description></item>
            /// <item><description><b>error</b></description></item>
            /// <item><description><b>success</b></description></item>
            /// <item><description><b>rollback</b></description></item>
            /// <item><description><b>rollback_success</b></description></item>
            /// <item><description><b>rollback_error</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>editing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the worker task belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1666884372152785</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E50D480-9765-5CFD-9650-9BACCECA5135</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
