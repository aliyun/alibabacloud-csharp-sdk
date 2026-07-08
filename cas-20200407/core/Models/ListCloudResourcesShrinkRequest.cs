// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCloudResourcesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The certificate IDs. Separate multiple IDs with commas (,).</para>
        /// </summary>
        [NameInMap("CertIds")]
        [Validation(Required=false)]
        public string CertIdsShrink { get; set; }

        /// <summary>
        /// <para>The cloud service provider.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Tencent</para>
        /// </description></item>
        /// <item><description><para>Huawei</para>
        /// </description></item>
        /// <item><description><para>Aws</para>
        /// </description></item>
        /// <item><description><para>aliyun</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("CloudName")]
        [Validation(Required=false)]
        public string CloudName { get; set; }

        /// <summary>
        /// <para>The cloud service name. Used to filter resources by cloud service.</para>
        /// <para>Valid values when CloudName is set to aliyun:</para>
        /// <list type="bullet">
        /// <item><description><para>SLB: Classic Load Balancer (CLB). This value is available only on the China site (aliyun.com).</para>
        /// </description></item>
        /// <item><description><para>LIVE: ApsaraVideo Live. This value is available only on the China site (aliyun.com).</para>
        /// </description></item>
        /// <item><description><para>webHosting: Cloud Web Hosting. This value is available only on the China site (aliyun.com).</para>
        /// </description></item>
        /// <item><description><para>VOD: ApsaraVideo VOD. This value is available only on the China site (aliyun.com).</para>
        /// </description></item>
        /// <item><description><para>CR: Container Registry. This value is available only on the China site (aliyun.com).</para>
        /// </description></item>
        /// <item><description><para>DCDN: Dynamic Content Delivery Network (DCDN).</para>
        /// </description></item>
        /// <item><description><para>DDOS: Anti-DDoS.</para>
        /// </description></item>
        /// <item><description><para>CDN: Alibaba Cloud CDN (CDN).</para>
        /// </description></item>
        /// <item><description><para>ALB: Application Load Balancer (ALB).</para>
        /// </description></item>
        /// <item><description><para>APIGateway: API Gateway.</para>
        /// </description></item>
        /// <item><description><para>FC: Function Compute.</para>
        /// </description></item>
        /// <item><description><para>GA: Global Accelerator (GA).</para>
        /// </description></item>
        /// <item><description><para>MSE: Microservices Engine (MSE).</para>
        /// </description></item>
        /// <item><description><para>NLB: Network Load Balancer (NLB).</para>
        /// </description></item>
        /// <item><description><para>OSS: Object Storage Service (OSS).</para>
        /// </description></item>
        /// <item><description><para>SAE: Serverless App Engine (SAE).</para>
        /// </description></item>
        /// <item><description><para>WAF: Web Application Firewall (WAF).</para>
        /// </description></item>
        /// </list>
        /// <para>Valid values when CloudName is set to Tencent:</para>
        /// <list type="bullet">
        /// <item><description><para>TencentCDN: Content Delivery Network (CDN).</para>
        /// </description></item>
        /// <item><description><para>TencentCLB: CLB.</para>
        /// </description></item>
        /// <item><description><para>TencentWAF: WAF.</para>
        /// </description></item>
        /// </list>
        /// <para>Valid value when CloudName is set to Huawei:</para>
        /// <list type="bullet">
        /// <item><description>HuaweiCDN: CDN.</description></item>
        /// </list>
        /// <para>Valid values when CloudName is set to Aws:</para>
        /// <list type="bullet">
        /// <item><description><para>AwsCloudFront: Amazon CloudFront.</para>
        /// </description></item>
        /// <item><description><para>AwsCLB: CLB.</para>
        /// </description></item>
        /// <item><description><para>AwsALB: ALB.</para>
        /// </description></item>
        /// <item><description><para>AwsNLB: NLB.</para>
        /// </description></item>
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
        /// <para>AK96*******6M</para>
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
