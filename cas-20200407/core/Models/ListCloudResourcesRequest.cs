// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCloudResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The certificate IDs.</para>
        /// </summary>
        [NameInMap("CertIds")]
        [Validation(Required=false)]
        public List<long?> CertIds { get; set; }

        /// <summary>
        /// <para>The cloud service provider.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Tencent</description></item>
        /// <item><description>Huawei</description></item>
        /// <item><description>Aws</description></item>
        /// <item><description>aliyun</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Tencent</para>
        /// </summary>
        [NameInMap("CloudName")]
        [Validation(Required=false)]
        public string CloudName { get; set; }

        /// <summary>
        /// <para>The cloud service.</para>
        /// <para>Valid values when CloudName is set to aliyun:</para>
        /// <list type="bullet">
        /// <item><description>SLB: Classic Load Balancer (CLB). This value is available only on the China site (aliyun.com).</description></item>
        /// <item><description>LIVE: ApsaraVideo Live. This value is available only on the China site (aliyun.com).</description></item>
        /// <item><description>webHosting: Cloud Web Hosting. This value is available only on the China site (aliyun.com).</description></item>
        /// <item><description>VOD: ApsaraVideo VOD. This value is available only on the China site (aliyun.com).</description></item>
        /// <item><description>CR: Container Registry. This value is available only on the China site (aliyun.com).</description></item>
        /// <item><description>DCDN: Dynamic Content Delivery Network (DCDN).</description></item>
        /// <item><description>DDOS: Anti-DDoS.</description></item>
        /// <item><description>CDN: Alibaba Cloud CDN (CDN).</description></item>
        /// <item><description>ALB: Application Load Balancer (ALB).</description></item>
        /// <item><description>APIGateway: API Gateway.</description></item>
        /// <item><description>FC: Function Compute.</description></item>
        /// <item><description>GA: Global Accelerator (GA).</description></item>
        /// <item><description>MSE: Microservices Engine (MSE).</description></item>
        /// <item><description>NLB: Network Load Balancer (NLB).</description></item>
        /// <item><description>OSS: Object Storage Service (OSS).</description></item>
        /// <item><description>SAE: Serverless App Engine (SAE).</description></item>
        /// <item><description>WAF: Web Application Firewall (WAF).</description></item>
        /// </list>
        /// <para>Valid values when CloudName is set to Tencent:</para>
        /// <list type="bullet">
        /// <item><description>TencentCDN: Content Delivery Network (CDN).</description></item>
        /// <item><description>TencentCLB: CLB.</description></item>
        /// <item><description>TencentWAF: WAF.</description></item>
        /// </list>
        /// <para>Valid value when CloudName is set to Huawei:</para>
        /// <list type="bullet">
        /// <item><description>HuaweiCDN: CDN.</description></item>
        /// </list>
        /// <para>Valid values when CloudName is set to Aws:</para>
        /// <list type="bullet">
        /// <item><description>AwsCloudFront: Amazon CloudFront.</description></item>
        /// <item><description>AwsCLB: CLB.</description></item>
        /// <item><description>AwsALB: ALB.</description></item>
        /// <item><description>AwsNLB: NLB.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SLB</para>
        /// </summary>
        [NameInMap("CloudProduct")]
        [Validation(Required=false)]
        public string CloudProduct { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The keyword of the domain name or instance ID bound to the cloud resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cert-instanceId</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The AccessKey ID that is used to access cloud resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("SecretId")]
        [Validation(Required=false)]
        public string SecretId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

    }

}
