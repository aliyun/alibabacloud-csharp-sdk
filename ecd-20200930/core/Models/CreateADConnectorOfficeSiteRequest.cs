// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateADConnectorOfficeSiteRequest : TeaModel {
        /// <summary>
        /// <para>The hostname of the domain controller. The hostname must comply with the naming conventions for Windows hosts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beijing-ad01</para>
        /// </summary>
        [NameInMap("AdHostname")]
        [Validation(Required=false)]
        public string AdHostname { get; set; }

        [NameInMap("BackupDCHostname")]
        [Validation(Required=false)]
        public string BackupDCHostname { get; set; }

        [NameInMap("BackupDns")]
        [Validation(Required=false)]
        public string BackupDns { get; set; }

        /// <summary>
        /// <para>The maximum public bandwidth of the Internet access package. Valid values: 0 to 200.\
        /// If you do not specify this parameter or you set this parameter to 0, Internet access is disabled.</para>
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
        /// <para>The Alibaba Cloud account that creates the Cloud Enterprise Network (CEN) instance.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify the CenId parameter, or the CEN instance that is specified by the CenId parameter belongs to the current Alibaba Cloud account, skip this parameter.</description></item>
        /// <item><description>If you specify the CenId parameter and the CEN instance that you specify for the CenId parameter belongs to another Alibaba Cloud account, enter the ID of the Alibaba Cloud account.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>102681951715****</para>
        /// </summary>
        [NameInMap("CenOwnerId")]
        [Validation(Required=false)]
        public long? CenOwnerId { get; set; }

        /// <summary>
        /// <para>The IPv4 CIDR block of the virtual private cloud (VPC) that your office network uses. The system creates a VPC for your office network based on the IPv4 CIDR block. We recommend that you set this parameter to one of the following CIDR blocks and their subnets:</para>
        /// <list type="bullet">
        /// <item><description><c>10.0.0.0/12</c> (subnet mask range: 12 to 24 bits)</description></item>
        /// <item><description><c>172.16.0.0/12</c> (subnet mask range: 12 to 24 bits)</description></item>
        /// <item><description><c>192.168.0.0/16</c> (subnet mask range: 16 to 24 bits)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>47.100.XX.XX</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The method to connect to cloud computers from Alibaba Cloud Workspace clients.</para>
        /// <remarks>
        /// <para> The VPC connection depends on Alibaba Cloud PrivateLink. You can use PrivateLink for free. When you set this parameter to <c>VPC</c> or <c>Any</c>, PrivateLink is automatically activated.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Internet: connects clients to cloud desktops only over the Internet. [Default]</description></item>
        /// <item><description>VPC: connects clients to cloud desktops only over a VPC.</description></item>
        /// <item><description>Any: connects clients to cloud desktops over the Internet or a VPC. You can select a connection method based on your business requirements when you connect to your cloud desktop from a client.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("DesktopAccessType")]
        [Validation(Required=false)]
        public string DesktopAccessType { get; set; }

        /// <summary>
        /// <para>The IP address of the DNS server of the enterprise AD system. You can specify only one IP address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("DnsAddress")]
        [Validation(Required=false)]
        public List<string> DnsAddress { get; set; }

        /// <summary>
        /// <para>The domain name of the enterprise AD system. You can register each domain name only once.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The password of the domain administrator. The password can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testPassword</para>
        /// </summary>
        [NameInMap("DomainPassword")]
        [Validation(Required=false)]
        public string DomainPassword { get; set; }

        /// <summary>
        /// <para>The username of the domain administrator. The username can be up to 64 characters in length.</para>
        /// <remarks>
        /// <para>Specify the username by using sAMAccountName instead of userPrincipalName.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Administrator</para>
        /// </summary>
        [NameInMap("DomainUserName")]
        [Validation(Required=false)]
        public string DomainUserName { get; set; }

        /// <summary>
        /// <para>Specifies whether to grant the local administrator permissions to users that are authorized to use cloud computers in the office network.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><!-- -->
        /// 
        /// <para>true</para>
        /// <!-- -->
        /// 
        /// <para>(default)</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><!-- -->
        /// 
        /// <para>false</para>
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAdminAccess")]
        [Validation(Required=false)]
        public bool? EnableAdminAccess { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Internet access.</para>
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
        /// <para>The office network name. The name must be 2 to 255 characters in length. It can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-). It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.\
        /// This parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        /// <summary>
        /// <para>The protocol type.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description><para>Adaptive Streaming Protocol (ASP)</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASP</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The AD connector type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: General</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>2: Advanced</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public long? Specification { get; set; }

        /// <summary>
        /// <para>The DNS address of the enterprise AD subdomain. If you specify <c>SubDomainName</c> but do not specify this parameter, the DNS address of the subdomain is the same as the DNS address of the parent domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SubDomainDnsAddress")]
        [Validation(Required=false)]
        public List<string> SubDomainDnsAddress { get; set; }

        /// <summary>
        /// <para>The domain name of the enterprise AD subdomain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>child.example.com</para>
        /// </summary>
        [NameInMap("SubDomainName")]
        [Validation(Required=false)]
        public string SubDomainName { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public List<string> VSwitchId { get; set; }

        /// <summary>
        /// <para>The verification code. If the CEN instance that you specify for the CenId parameter belongs to another Alibaba Cloud account, you must call the <a href="https://help.aliyun.com/document_detail/436847.html">SendVerifyCode</a> operation to obtain the verification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("VerifyCode")]
        [Validation(Required=false)]
        public string VerifyCode { get; set; }

    }

}
