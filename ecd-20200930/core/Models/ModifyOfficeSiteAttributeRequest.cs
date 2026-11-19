// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyOfficeSiteAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The authority URL of the identity authentication service.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://login.microsoftonline.com">https://login.microsoftonline.com</a></para>
        /// </summary>
        [NameInMap("AuthorityHost")]
        [Validation(Required=false)]
        public string AuthorityHost { get; set; }

        /// <summary>
        /// <para>The client ID registered for the identity provider application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2c8f7e4-1b3d-4c5e-9f0a-6d7b8c9e****</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The client secret registered for the identity provider application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sct-9f3e2d1c****</para>
        /// </summary>
        [NameInMap("ClientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// <para>The access method allowed when connecting to cloud desktops.</para>
        /// <remarks>
        /// <para>The VPC connection method relies on the Alibaba Cloud PrivateLink service, which is free of charge. If you set this parameter to <c>VPC</c> or <c>Any</c>, the system automatically activates the PrivateLink service for you.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>INTERNET</para>
        /// </summary>
        [NameInMap("DesktopAccessType")]
        [Validation(Required=false)]
        public string DesktopAccessType { get; set; }

        /// <summary>
        /// <para>The domain name of the enterprise AD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>domain.local</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether to grant local administrator permissions to users of cloud desktops.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableAdminAccess")]
        [Validation(Required=false)]
        public bool? EnableAdminAccess { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable User Profile Management (UPM). Currently, you can only set this parameter to false to unbind UPM from the workspace. To enable UPM, call the CreateAndBindNasFileSystem operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableUpm")]
        [Validation(Required=false)]
        public bool? EnableUpm { get; set; }

        /// <summary>
        /// <para>Applies only to office networks with convenience accounts. Specifies whether secondary authentication is required during logon. If secondary authentication is enabled, the system checks for security risks when a convenience user logs on to the client. If risks are detected, the system sends a verification code to the email address associated with the account. The convenience user can log on to the client only after entering the correct verification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedVerifyLoginRisk")]
        [Validation(Required=false)]
        public bool? NeedVerifyLoginRisk { get; set; }

        /// <summary>
        /// <para>Applies only to office networks with convenience accounts. Specifies whether to enable device verification. For AD office networks, this parameter is left empty.</para>
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
        /// <para>The name of the office network. The name must be 2 to 255 characters in length, and can contain letters and Chinese characters. It must start with a letter or a Chinese character, and cannot start with <c>http://</c> or <c>https://</c>. It can contain digits, colons (:), underscores (_), and hyphens (-).<br>Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>R&amp;D Department Office Network</para>
        /// </summary>
        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the regions supported by Wuying Workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The tenant ID of the identity provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72f988bf-86f1-41af-91ab-2d7cd011****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. Currently, you can configure only one vSwitch.</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public List<string> VSwitchId { get; set; }

    }

}
