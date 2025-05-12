// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyADConnectorOfficeSiteRequest : TeaModel {
        /// <summary>
        /// <para>The hostname of the domain controller. The hostname must comply with the naming conventions for hostnames in Windows.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beijing-ad01</para>
        /// </summary>
        [NameInMap("AdHostname")]
        [Validation(Required=false)]
        public string AdHostname { get; set; }

        /// <summary>
        /// <para>The hostname of the secondary domain controller.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc002</para>
        /// </summary>
        [NameInMap("BackupDCHostname")]
        [Validation(Required=false)]
        public string BackupDCHostname { get; set; }

        /// <summary>
        /// <para>The IP address of the DNS server corresponding to the secondary domain controller.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.2.100</para>
        /// </summary>
        [NameInMap("BackupDns")]
        [Validation(Required=false)]
        public string BackupDns { get; set; }

        /// <summary>
        /// <para>The IP addresses of the DNS servers corresponding to the enterprise ADs. You can specify only one DNS IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.<em>.</em></para>
        /// </summary>
        [NameInMap("DnsAddress")]
        [Validation(Required=false)]
        public List<string> DnsAddress { get; set; }

        /// <summary>
        /// <para>The domain name of the enterprise AD system. You can register each domain name only once.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The password of the domain administrator. The username can be up to 64 characters in length.</para>
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
        /// <para>Specify the value of the sAMAccountName parameter instead of the value of the userPrincipalName parameter as the username.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Administrator</para>
        /// </summary>
        [NameInMap("DomainUserName")]
        [Validation(Required=false)]
        public string DomainUserName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable multi-factor authentication (MFA).</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>false</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MfaEnabled")]
        [Validation(Required=false)]
        public bool? MfaEnabled { get; set; }

        /// <summary>
        /// <para>The name of the organizational unit (OU) in the AD domain. You can call the <a href="https://help.aliyun.com/document_detail/311259.html">ListUserAdOrganizationUnits</a> operation to obtain OUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oldad.com/Domain Controllers</para>
        /// </summary>
        [NameInMap("OUName")]
        [Validation(Required=false)]
        public string OUName { get; set; }

        /// <summary>
        /// <para>The office network ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-363353****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The office network name. The name must be 2 to 255 characters in length. It can contain letters, digits, colons (:), underscores (_), and hyphens (-). It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the list of regions where Elastic Desktop Service (EDS) Enterprise is available.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IP addresses of the DNS servers corresponding to the enterprise AD subdomains. You can specify only one DNS IP address. If you specify <c>SubDomainName</c> and leave this parameter empty, the value is the same as that of the enterprise AD domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.<em>.</em></para>
        /// </summary>
        [NameInMap("SubDomainDnsAddress")]
        [Validation(Required=false)]
        public List<string> SubDomainDnsAddress { get; set; }

        /// <summary>
        /// <para>The name of the subdomain in the enterprise AD domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>childexample.com</para>
        /// </summary>
        [NameInMap("SubDomainName")]
        [Validation(Required=false)]
        public string SubDomainName { get; set; }

    }

}
