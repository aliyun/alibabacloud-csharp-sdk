// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyADConnectorOfficeSiteRequest : TeaModel {
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
        /// <para>The IP address of the DNS server corresponding to the enterprise AD. Currently, only one IP address can be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.<em>.</em></para>
        /// </summary>
        [NameInMap("DnsAddress")]
        [Validation(Required=false)]
        public List<string> DnsAddress { get; set; }

        /// <summary>
        /// <para>The domain name of the enterprise AD. The same domain name can be registered only once.</para>
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
        /// <para>Use sAMAccountName for the username. Do not use userPrincipalName.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MfaEnabled")]
        [Validation(Required=false)]
        public bool? MfaEnabled { get; set; }

        /// <summary>
        /// <para>The organizational unit (OU) of the AD domain. You can call <a href="https://help.aliyun.com/document_detail/311259.html">ListUserAdOrganizationUnits</a> to obtain the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com/Domain Controllers</para>
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
        /// <para>The office network name. The name must be 2 to 255 characters in length. It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>. The name can contain digits, colons (:), underscores (_), or hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

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
        /// <para>The DNS address of the enterprise AD subdomain. Currently, only one address can be specified. If <c>SubDomainName</c> is specified but this parameter is not, the subdomain DNS defaults to the same value as the parent domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.<em>.</em></para>
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

    }

}
