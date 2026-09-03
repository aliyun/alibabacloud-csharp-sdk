// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateADConnectorOfficeSiteRequest : TeaModel {
        /// <summary>
        /// <para>The access attribute of the office network (workspace).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Private</para>
        /// </summary>
        [NameInMap("AccessAttribute")]
        [Validation(Required=false)]
        public string AccessAttribute { get; set; }

        /// <summary>
        /// <para>The hostname of the domain controller. The hostname must comply with Windows hostname naming conventions.</para>
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
        /// <para>The peak Internet bandwidth, in Mbit/s. Valid values: 0 to 200.<br>If you do not set this parameter or set it to 0, the Internet access feature is not enabled. Settings take effect immediately.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The instance ID of the Cloud Enterprise Network (CEN).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-3gwy16dojz1m65****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the Cloud Enterprise Network (CEN) instance owner.</para>
        /// <list type="bullet">
        /// <item><description>If CenId is not specified, or the specified CenId belongs to the current Alibaba Cloud account, you do not need to specify this parameter.</description></item>
        /// <item><description>If the specified CenId belongs to another Alibaba Cloud account, specify the Alibaba Cloud account ID of that account.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>102681951715****</para>
        /// </summary>
        [NameInMap("CenOwnerId")]
        [Validation(Required=false)]
        public long? CenOwnerId { get; set; }

        /// <summary>
        /// <para>The IPv4 CIDR block of the office network VPC. The system uses automatic creation to provision a VPC based on the specified IPv4 CIDR block. Use one of the following CIDR blocks or their subnets as the IPv4 CIDR block:</para>
        /// <list type="bullet">
        /// <item><description><c>10.0.0.0/12</c> (valid mask range: 12 to 24 bits)</description></item>
        /// <item><description><c>172.16.0.0/12</c> (valid mask range: 12 to 24 bits)</description></item>
        /// <item><description><c>192.168.0.0/16</c> (valid mask range: 16 to 24 bits)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>47.100.XX.XX</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The access method allowed when connecting to cloud computers.</para>
        /// <remarks>
        /// <para>The VPC connection method depends on the Alibaba Cloud PrivateLink service, which is free of charge. If this parameter is set to <c>VPC</c> or <c>Any</c>, the system automatically activates the PrivateLink service for you.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("DesktopAccessType")]
        [Validation(Required=false)]
        public string DesktopAccessType { get; set; }

        /// <summary>
        /// <para>The IP address of the DNS server corresponding to the enterprise AD. Currently, only one IP address is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("DnsAddress")]
        [Validation(Required=false)]
        public List<string> DnsAddress { get; set; }

        /// <summary>
        /// <para>The domain name of the enterprise AD. The same domain name can be registered only once.</para>
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
        /// <para>Use the sAMAccountName format for the username. Do not use the userPrincipalName format.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Administrator</para>
        /// </summary>
        [NameInMap("DomainUserName")]
        [Validation(Required=false)]
        public string DomainUserName { get; set; }

        /// <summary>
        /// <para>Specifies whether to grant local administrator permissions to users who use cloud computers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAdminAccess")]
        [Validation(Required=false)]
        public bool? EnableAdminAccess { get; set; }

        /// <summary>
        /// <para>Specifies whether public network access is enabled. This parameter indicates whether the feature is active.</para>
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
        /// <para>The name of the office network. The name must be 2 to 255 characters in length and can contain letters, digits, colons (:), underscores (_), and hyphens (-). The name must start with a letter or Chinese character and cannot start with <c>http://</c> or <c>https://</c>.<br>Default value: null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RD_Office_Network</para>
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
        /// <para>The region ID. You can call <a href="~~DescribeRegions~~">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The AD Connector specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public long? Specification { get; set; }

        /// <summary>
        /// <para>The DNS address of the enterprise AD subdomain. If <c>SubDomainName</c> is specified but this parameter is not, the subdomain DNS is considered the same as the parent domain DNS.</para>
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

        /// <summary>
        /// <para>The list of vSwitch IDs.</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public List<string> VSwitchId { get; set; }

        /// <summary>
        /// <para>The verification code. If the specified CenId belongs to another Alibaba Cloud account, you must first call <a href="https://help.aliyun.com/document_detail/436847.html">SendVerifyCode</a> to obtain the verification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("VerifyCode")]
        [Validation(Required=false)]
        public string VerifyCode { get; set; }

    }

}
