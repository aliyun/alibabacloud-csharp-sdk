// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListDeploymentJobResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDeploymentJobResourceResponseBodyData> Data { get; set; }
        public class ListDeploymentJobResourceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The end date of the certificate bound to the cloud resource. The value is a timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1681956830000</para>
            /// </summary>
            [NameInMap("CertEndTime")]
            [Validation(Required=false)]
            public string CertEndTime { get; set; }

            /// <summary>
            /// <para>The ID of the certificate bound to the cloud resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11599949</para>
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public long? CertId { get; set; }

            /// <summary>
            /// <para>The name of the certificate bound to the cloud resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sc-SSL</para>
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>The start date of the certificate bound to the cloud resource. The value is a timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1681956830000</para>
            /// </summary>
            [NameInMap("CertStartTime")]
            [Validation(Required=false)]
            public string CertStartTime { get; set; }

            /// <summary>
            /// <para>The AccessKey ID used to access cloud resources.</para>
            /// <remarks>
            /// <para> This parameter is required only when you deploy certificates to services of multiple clouds.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("CloudAccessId")]
            [Validation(Required=false)]
            public string CloudAccessId { get; set; }

            /// <summary>
            /// <para>The cloud service provider of the cloud resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>aliyun</b>: Alibaba Cloud</description></item>
            /// <item><description><b>Tencent</b>: Tencent Cloud</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun</para>
            /// </summary>
            [NameInMap("CloudName")]
            [Validation(Required=false)]
            public string CloudName { get; set; }

            /// <summary>
            /// <para>The cloud service. Valid values:</para>
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
            /// <para>The region ID of the cloud service provider to which the cloud resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("CloudRegion")]
            [Validation(Required=false)]
            public string CloudRegion { get; set; }

            /// <summary>
            /// <para>Indicates whether the cloud resource is the default resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes</description></item>
            /// <item><description><b>0</b>: no</description></item>
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
            public int? DefaultResource { get; set; }

            /// <summary>
            /// <para>The domain name bound to the cloud resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyundoc.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Indicates whether HTTPS is enabled for the cloud resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes</description></item>
            /// <item><description><b>0</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EnableHttps")]
            [Validation(Required=false)]
            public int? EnableHttps { get; set; }

            /// <summary>
            /// <para>The time when the cloud resource was created. The time is a timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1673423339000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the cloud resource was last modified. The time is in the timestamp format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1681956830000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the cloud resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20979</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The instance ID of the cloud resource.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the value of CloudProduct is SLB, NLB, ALB, or GA.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cas-cn-m7r1qocw91at</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The listener ID of the cloud resource.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the value of CloudProduct is SLB, NLB, ALB, or GA.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>lsn-vwdff0q20poq5xazb9@443</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The listening port of the cloud resource.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the value of CloudProduct is SLB, NLB, ALB, or GA.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8047</para>
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public string ListenerPort { get; set; }

            /// <summary>
            /// <para>The region ID of the cloud resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The other metadata related to the cloud resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;camera_model\&quot;:\&quot;GIFSHOW [1267087617][OnePlus</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The status of the cloud resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Indicates whether an Alibaba Cloud SSL certificate is used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes</description></item>
            /// <item><description><b>0</b>: no</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is required only when you deploy certificates to services of multiple clouds.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UseSsl")]
            [Validation(Required=false)]
            public int? UseSsl { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
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
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
