// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyOfficeSiteAttributeRequest : TeaModel {
        [NameInMap("AuthorityHost")]
        [Validation(Required=false)]
        public string AuthorityHost { get; set; }

        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("ClientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// <para>The method to connect to cloud computers from Alibaba Cloud Workspace clients.</para>
        /// <remarks>
        /// <para> VPC connection relies on the Alibaba Cloud PrivateLink service. You can use PrivateLink for free. When you set this parameter to <c>VPC</c> or <c>Any</c>, the system automatically activates PrivateLink.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>INTERNET (default): allows end users to connect to cloud computers over the Internet.</description></item>
        /// <item><description>VPC: allows end users to connect to cloud computers over VPCs.</description></item>
        /// <item><description>ANY: allows end users to connect to cloud computers over the Internet and VPCs. When end users connect to cloud computers from Elastic Desktop Service, you can choose a connection method based on your business requirements.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INTERNET</para>
        /// </summary>
        [NameInMap("DesktopAccessType")]
        [Validation(Required=false)]
        public string DesktopAccessType { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether to grant the local administrator permissions to users that are authorized to use cloud computers in the office network.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default)</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAdminAccess")]
        [Validation(Required=false)]
        public bool? EnableAdminAccess { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable two-factor verification when an end user logs on to an Alibaba Cloud Workspace client. This parameter is required only for convenience office networks. If two-factor verification is enabled, the system checks whether security risks exist within the logon account when the end user uses a convenience user to log on to the client. If risks are detected, the system sends a verification code to the email address that is associated with the account of the convenience user. Then, the end user can log on to the client only when the verification code is correct.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedVerifyLoginRisk")]
        [Validation(Required=false)]
        public bool? NeedVerifyLoginRisk { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable device verification. This parameter is required only for convenience office networks. This parameter is left empty for enterprise Active Directory (AD) office networks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedVerifyZeroDevice")]
        [Validation(Required=false)]
        public bool? NeedVerifyZeroDevice { get; set; }

        /// <summary>
        /// <para>The office network ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-882398****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

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
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
