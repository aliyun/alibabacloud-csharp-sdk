// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedInstanceDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The exposure details about the server.</para>
        /// </summary>
        [NameInMap("ExposedChains")]
        [Validation(Required=false)]
        public List<DescribeExposedInstanceDetailResponseBodyExposedChains> ExposedChains { get; set; }
        public class DescribeExposedInstanceDetailResponseBodyExposedChains : TeaModel {
            /// <summary>
            /// <para>The information about all vulnerabilities on the server.</para>
            /// </summary>
            [NameInMap("AllVulList")]
            [Validation(Required=false)]
            public List<DescribeExposedInstanceDetailResponseBodyExposedChainsAllVulList> AllVulList { get; set; }
            public class DescribeExposedInstanceDetailResponseBodyExposedChainsAllVulList : TeaModel {
                /// <summary>
                /// <para>The alias of the vulnerability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RHSA-2022:0274-Important: polkit pkexec Local Privilege Escalation Vulnerability(CVE-2021-4034)</para>
                /// </summary>
                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

                /// <summary>
                /// <para>The name of the vulnerability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SCA:ACSV-2020-052801</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The priority to fix the vulnerability. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>asap</b>: high</description></item>
                /// <item><description><b>later</b>: medium</description></item>
                /// <item><description><b>nntf</b>: low</description></item>
                /// </list>
                /// <remarks>
                /// <para> We recommend that you fix the vulnerabilities that have the <b>high</b> priority at the earliest opportunity.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>asap</para>
                /// </summary>
                [NameInMap("Necessity")]
                [Validation(Required=false)]
                public string Necessity { get; set; }

                /// <summary>
                /// <para>The type of the vulnerability. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cve</b>: Linux software vulnerabilities</description></item>
                /// <item><description><b>sys</b>: Windows system vulnerabilities</description></item>
                /// <item><description><b>cms</b>: Web-CMS vulnerabilities</description></item>
                /// <item><description><b>app</b>: application vulnerabilities</description></item>
                /// <item><description><b>emg</b>: urgent vulnerabilities</description></item>
                /// <item><description><b>sca</b>: middleware vulnerabilities</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sca</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The UUID of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4f9ce097-4a7d-48fe-baef-6960e5b6****</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// <para>The server component that is exposed on the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>openssl,openssh</para>
            /// </summary>
            [NameInMap("ExposureComponent")]
            [Validation(Required=false)]
            public string ExposureComponent { get; set; }

            /// <summary>
            /// <para>The public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.99.XX.XX</para>
            /// </summary>
            [NameInMap("ExposureIp")]
            [Validation(Required=false)]
            public string ExposureIp { get; set; }

            /// <summary>
            /// <para>The port that is exposed on the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("ExposurePort")]
            [Validation(Required=false)]
            public string ExposurePort { get; set; }

            /// <summary>
            /// <para>The resource from which the server is exposed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INTERNET_IP</b>: the public IP address of an Elastic Compute Service (ECS) instance</description></item>
            /// <item><description><b>SLB</b>: the public IP address of a Server Load Balancer (SLB) instance</description></item>
            /// <item><description><b>EIP</b>: an elastic IP address (EIP)</description></item>
            /// <item><description><b>DNAT</b>: the NAT gateway that connects to the Internet by using the DNAT feature</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INTERNET_IP</para>
            /// </summary>
            [NameInMap("ExposureType")]
            [Validation(Required=false)]
            public string ExposureType { get; set; }

            /// <summary>
            /// <para>The ID of the instance to which the resource belongs. The valid values of this parameter vary based on the value of the ExposureType parameter.</para>
            /// <list type="bullet">
            /// <item><description>If the value of the ExposureType parameter is <b>INTERNET_IP</b>, the value of this parameter is an empty string.</description></item>
            /// <item><description>If the value of the ExposureType parameter is <b>SLB</b>, the value of this parameter is the ID of the Internet-facing SLB instance.</description></item>
            /// <item><description>If the value of the ExposureType parameter is <b>EIP</b>, the value of this parameter is the ID of the EIP.</description></item>
            /// <item><description>If the value of the ExposureType parameter is <b>DNAT</b>, the value of this parameter is the ID of the NAT gateway.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>eip-bp1bkgowzam49rld3****</para>
            /// </summary>
            [NameInMap("ExposureTypeId")]
            [Validation(Required=false)]
            public string ExposureTypeId { get; set; }

            /// <summary>
            /// <para>The server group to which the server belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp1iw5enua6gf5i2xr7z</para>
            /// </summary>
            [NameInMap("GroupNo")]
            [Validation(Required=false)]
            public string GroupNo { get; set; }

            /// <summary>
            /// <para>The ID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp116qem8npvchqc****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>worker-k8s-for-cs-c929ee2a145214f89a8b248005be5****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.99.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The information about the vulnerabilities that are exposed on the Internet and can be exploited by attackers.</para>
            /// </summary>
            [NameInMap("RealVulList")]
            [Validation(Required=false)]
            public List<DescribeExposedInstanceDetailResponseBodyExposedChainsRealVulList> RealVulList { get; set; }
            public class DescribeExposedInstanceDetailResponseBodyExposedChainsRealVulList : TeaModel {
                /// <summary>
                /// <para>The alias of the vulnerability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RHSA-2022:0274-Important: polkit pkexec Local Privilege Escalation Vulnerability(CVE-2021-4034)</para>
                /// </summary>
                [NameInMap("AliasName")]
                [Validation(Required=false)]
                public string AliasName { get; set; }

                /// <summary>
                /// <para>The name of the vulnerability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SCA:ACSV-2020-052801</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The priority to fix the vulnerability. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>asap</b>: high</description></item>
                /// <item><description><b>later</b>: medium</description></item>
                /// <item><description><b>nntf</b>: low</description></item>
                /// </list>
                /// <remarks>
                /// <para> We recommend that you fix the vulnerabilities that have the <b>high</b> priority at the earliest opportunity.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>asap</para>
                /// </summary>
                [NameInMap("Necessity")]
                [Validation(Required=false)]
                public string Necessity { get; set; }

                /// <summary>
                /// <para>The type of the vulnerability. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cve</b>: Linux software vulnerabilities</description></item>
                /// <item><description><b>sys</b>: Windows system vulnerabilities</description></item>
                /// <item><description><b>cms</b>: Web-CMS vulnerabilities</description></item>
                /// <item><description><b>app</b>: application vulnerabilities</description></item>
                /// <item><description><b>emg</b>: urgent vulnerabilities</description></item>
                /// <item><description><b>sca</b>: middleware vulnerabilities</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sca</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The UUID of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4f9ce097-4a7d-48fe-baef-6960e5b6****</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// <para>The region in which the server resides.</para>
            /// <remarks>
            /// <para> For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The UUID of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4f9ce097-4a7d-48fe-baef-6960e5b6****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C590482B-54A7-4273-8115-9DBE2DE46B26</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
