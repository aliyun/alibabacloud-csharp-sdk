// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateADConnectorOfficeSiteRequest : TeaModel {
        [NameInMap("AccessAttribute")]
        [Validation(Required=false)]
        public string AccessAttribute { get; set; }

        /// <summary>
        /// <para>The domain controller hostname.
        /// The hostname must comply with Windows hostname naming conventions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beijing-ad01</para>
        /// </summary>
        [NameInMap("AdHostname")]
        [Validation(Required=false)]
        public string AdHostname { get; set; }

        /// <summary>
        /// <para>The hostname of the backup domain controller.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc002</para>
        /// </summary>
        [NameInMap("BackupDCHostname")]
        [Validation(Required=false)]
        public string BackupDCHostname { get; set; }

        /// <summary>
        /// <para>The DNS address of the backup domain controller.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.2.100</para>
        /// </summary>
        [NameInMap("BackupDns")]
        [Validation(Required=false)]
        public string BackupDns { get; set; }

        /// <summary>
        /// <para>The peak public bandwidth, specified in Mbit/s. The value can range from 0 to 200.<br>
        /// If you omit this parameter or set it to 0, internet access is disabled.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The ID of the CEN instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-3gwy16dojz1m65****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that owns the Cloud Enterprise Network (CEN) instance.</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify <c>CenId</c>, or the specified CEN instance belongs to your Alibaba Cloud account, you do not need to specify this parameter.</para>
        /// </description></item>
        /// <item><description><para>If the specified CEN instance belongs to another Alibaba Cloud account, you must specify that account\&quot;s ID.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>102681951715****</para>
        /// </summary>
        [NameInMap("CenOwnerId")]
        [Validation(Required=false)]
        public long? CenOwnerId { get; set; }

        /// <summary>
        /// <para>The IPv4 CIDR block for the office site\&quot;s VPC. The system uses this IPv4 CIDR block to automatically create a VPC. We recommend that you use one of the following CIDR blocks or their subnets:</para>
        /// <list type="bullet">
        /// <item><description><para><c>10.0.0.0/12</c> (The subnet mask length must be 12 to 24 bits.)</para>
        /// </description></item>
        /// <item><description><para><c>172.16.0.0/12</c> (The subnet mask length must be 12 to 24 bits.)</para>
        /// </description></item>
        /// <item><description><para><c>192.168.0.0/16</c> (The subnet mask length must be 16 to 24 bits.)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>47.100.XX.XX</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The method for connecting to cloud desktops.</para>
        /// <remarks>
        /// <para>VPC connections are established using Alibaba Cloud PrivateLink, which is a free service. If you set this parameter to <c>VPC</c> or <c>Any</c>, PrivateLink is automatically enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("DesktopAccessType")]
        [Validation(Required=false)]
        public string DesktopAccessType { get; set; }

        /// <summary>
        /// <para>An array that contains the IP address of the DNS server for the enterprise AD. You can specify only one IP address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("DnsAddress")]
        [Validation(Required=false)]
        public List<string> DnsAddress { get; set; }

        /// <summary>
        /// <para>The domain name for the enterprise AD. Each domain name must be unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The domain administrator\&quot;s password. The password cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testPassword</para>
        /// </summary>
        [NameInMap("DomainPassword")]
        [Validation(Required=false)]
        public string DomainPassword { get; set; }

        /// <summary>
        /// <para>The domain administrator\&quot;s username. The username cannot exceed 64 characters in length.</para>
        /// <remarks>
        /// <para>Use the sAMAccountName, not the userPrincipalName.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Administrator</para>
        /// </summary>
        [NameInMap("DomainUserName")]
        [Validation(Required=false)]
        public string DomainUserName { get; set; }

        /// <summary>
        /// <para>Specifies whether to grant local administrator permissions to cloud desktop users. Default: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAdminAccess")]
        [Validation(Required=false)]
        public bool? EnableAdminAccess { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. Use the <c>Bandwidth</c> parameter to manage internet access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableInternetAccess")]
        [Validation(Required=false)]
        public bool? EnableInternetAccess { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable multi-factor authentication (MFA).</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MfaEnabled")]
        [Validation(Required=false)]
        public bool? MfaEnabled { get; set; }

        /// <summary>
        /// <para>The name of the office site. The name must be 2 to 255 characters in length. It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>. The name can contain digits, colons (:), underscores (_), and hyphens (-).<br>
        /// This parameter is empty by default.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        /// <summary>
        /// <para>The protocol type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASP</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the regions supported by Elastic Desktop Service (EDS).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The AD Connector type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public long? Specification { get; set; }

        /// <summary>
        /// <para>The DNS address of the enterprise AD child domain. If you specify <c>SubDomainName</c> but not this parameter, the DNS address of the child domain is considered the same as that of the parent domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SubDomainDnsAddress")]
        [Validation(Required=false)]
        public List<string> SubDomainDnsAddress { get; set; }

        /// <summary>
        /// <para>The domain name of the enterprise AD child domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>child.example.com</para>
        /// </summary>
        [NameInMap("SubDomainName")]
        [Validation(Required=false)]
        public string SubDomainName { get; set; }

        /// <summary>
        /// <para>The list of vSwitch IDs.</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public List<string> VSwitchId { get; set; }

        /// <summary>
        /// <para>The verification code. If the <c>CenId</c> that you specify belongs to another Alibaba Cloud account, you must first call the <a href="https://help.aliyun.com/document_detail/436847.html">SendVerifyCode</a> operation to obtain the verification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("VerifyCode")]
        [Validation(Required=false)]
        public string VerifyCode { get; set; }

    }

}
