// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListDeploymentJobResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDeploymentJobResourceResponseBodyData> Data { get; set; }
        public class ListDeploymentJobResourceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The expiration date of the certificate that is attached to the cloud product resource. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1681956830000</para>
            /// </summary>
            [NameInMap("CertEndTime")]
            [Validation(Required=false)]
            public string CertEndTime { get; set; }

            /// <summary>
            /// <para>The ID of the certificate that is attached to the cloud product resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11599949</para>
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public long? CertId { get; set; }

            /// <summary>
            /// <para>The name of the certificate that is attached to the cloud product resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sc-SSL</para>
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>The start date of the certificate that is attached to the cloud product resource. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1681956830000</para>
            /// </summary>
            [NameInMap("CertStartTime")]
            [Validation(Required=false)]
            public string CertStartTime { get; set; }

            /// <summary>
            /// <para>The key ID used to access the cloud resource set.</para>
            /// <remarks>
            /// <para>This parameter is returned only for multicloud deployments.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("CloudAccessId")]
            [Validation(Required=false)]
            public string CloudAccessId { get; set; }

            /// <summary>
            /// <para>The provider of the cloud product resource.</para>
            /// <list type="bullet">
            /// <item><description><para><b>aliyun</b>: Alibaba Cloud</para>
            /// </description></item>
            /// <item><description><para><b>Tencent</b>: Tencent Cloud</para>
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
            /// <para>The cloud service.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><para><b>SLB</b>: Classic Load Balancer (CLB) (China site only)</para>
            /// </description></item>
            /// <item><description><para><b>LIVE</b>: ApsaraVideo Live (China site only)</para>
            /// </description></item>
            /// <item><description><para><b>webHosting</b>: Cloud Web Hosting (China site only)</para>
            /// </description></item>
            /// <item><description><para><b>VOD</b>: ApsaraVideo VOD (China site only)</para>
            /// </description></item>
            /// <item><description><para><b>CR</b>: Container Registry (China site only)</para>
            /// </description></item>
            /// <item><description><para><b>DCDN</b>: DCDN</para>
            /// </description></item>
            /// <item><description><para><b>DDOS</b>: Anti-DDoS</para>
            /// </description></item>
            /// <item><description><para><b>CDN</b>: Alibaba Cloud CDN</para>
            /// </description></item>
            /// <item><description><para><b>ALB</b>: Application Load Balancer</para>
            /// </description></item>
            /// <item><description><para><b>APIGateway</b>: API Gateway</para>
            /// </description></item>
            /// <item><description><para><b>FC</b>: Function Compute</para>
            /// </description></item>
            /// <item><description><para><b>GA</b>: Global Accelerator</para>
            /// </description></item>
            /// <item><description><para><b>MSE</b>: MSE</para>
            /// </description></item>
            /// <item><description><para><b>NLB</b>: Network Load Balancer</para>
            /// </description></item>
            /// <item><description><para><b>OSS</b>: OSS</para>
            /// </description></item>
            /// <item><description><para><b>SAE</b>: SAE</para>
            /// </description></item>
            /// <item><description><para><b>TencentCDN</b>: Tencent CDN</para>
            /// </description></item>
            /// <item><description><para><b>WAF</b>: WAF</para>
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
            /// <para>The region ID of the cloud product resource from the cloud provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("CloudRegion")]
            [Validation(Required=false)]
            public string CloudRegion { get; set; }

            /// <summary>
            /// <para>Indicates whether the cloud product resource is a default resource.</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Default resource</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: Not a default resource</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is returned only for deployments of SLB, NLB, ALB, and GA.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DefaultResource")]
            [Validation(Required=false)]
            public int? DefaultResource { get; set; }

            /// <summary>
            /// <para>The domain name that is attached to the cloud product resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyundoc.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Indicates whether HTTPS is enabled for the cloud product resource.</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Enabled</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: Disabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EnableHttps")]
            [Validation(Required=false)]
            public int? EnableHttps { get; set; }

            /// <summary>
            /// <para>The time when the synchronized resource was created. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1673423339000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the synchronized resource was last modified. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1681956830000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the cloud product resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20979</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The instance ID of the cloud product resource.</para>
            /// <remarks>
            /// <para>This parameter is returned only for deployments of SLB, NLB, ALB, and GA.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cas-cn-m7r1qocw91at</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The listener ID of the cloud product resource.</para>
            /// <remarks>
            /// <para>This parameter is returned only for deployments of SLB, NLB, ALB, and GA.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>lsn-vwdff0q20poq5xazb9@443</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The listener port of the cloud product resource.</para>
            /// <remarks>
            /// <para>This parameter is returned only for deployments of SLB, NLB, ALB, and GA.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8047</para>
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public string ListenerPort { get; set; }

            /// <summary>
            /// <para>The region ID of the synchronized cloud product resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Other metadata about the cloud product resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;camera_model\&quot;:\&quot;GIFSHOW [1267087617][OnePlus</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The status of the synchronized cloud product resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Indicates whether an Alibaba Cloud SSL certificate is used.</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Yes</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: No</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is returned only for multicloud deployments.</para>
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
            /// <para>1666884372******</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
