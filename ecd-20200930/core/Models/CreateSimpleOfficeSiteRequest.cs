// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateSimpleOfficeSiteRequest : TeaModel {
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
        /// <para>The account type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SIMPLE</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

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
        /// <para>The peak Internet bandwidth. Valid values: 10 to 200. Unit: Mbit/s.
        /// You can specify this parameter when <c>EnableInternetAccess</c> is set to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The instance ID of the Cloud Enterprise Network (CEN) instance.</para>
        /// <remarks>
        /// <para>To connect to cloud desktops over a VPC connection, add the office network to a CEN instance. The CEN instance is the one that the on-premises network connects to by using a VPN or Express Connect circuit.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cen-3gwy16dojz1m65****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID to which the CEN instance belongs.</para>
        /// <list type="bullet">
        /// <item><description>If CenId is not specified or the specified CEN instance belongs to the current Alibaba Cloud account, you do not need to specify this parameter.</description></item>
        /// <item><description>If the specified CEN instance belongs to another Alibaba Cloud account, specify the Alibaba Cloud account ID of that account.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>118272523431****</para>
        /// </summary>
        [NameInMap("CenOwnerId")]
        [Validation(Required=false)]
        public long? CenOwnerId { get; set; }

        /// <summary>
        /// <para>The IPv4 CIDR block of the VPC for the office network. This parameter is required for advanced office networks. The system uses automatic creation of a VPC based on the specified IPv4 CIDR block. Use one of the following CIDR blocks or their subnets:</para>
        /// <list type="bullet">
        /// <item><description><c>10.0.0.0/12</c> (valid mask range: 12 to 24 bits)</description></item>
        /// <item><description><c>172.16.0.0/12</c> (valid mask range: 12 to 24 bits)</description></item>
        /// <item><description><c>192.168.0.0/16</c> (valid mask range: 16 to 24 bits)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.0/12</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The client ID registered with the identity provider application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2c8f7e4-1b3d-4c5e-9f0a-6d7b8c9e****</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The client secret registered with the identity provider application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sct-9f3e2d1c****</para>
        /// </summary>
        [NameInMap("ClientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// <para>Specifies whether the office network is a CloudBox office network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CloudBoxOfficeSite")]
        [Validation(Required=false)]
        public bool? CloudBoxOfficeSite { get; set; }

        /// <summary>
        /// <para>The access method allowed when connecting to cloud desktops.</para>
        /// <remarks>
        /// <para>The VPC connection method depends on the Alibaba Cloud PrivateLink service, which is free of charge. If this parameter is set to <c>VPC</c> or <c>Any</c>, the system automatically activates the PrivateLink service.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
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
        /// <para>The enterprise ID (EID).</para>
        /// 
        /// <b>Example:</b>
        /// <para>e-1234abcd****</para>
        /// </summary>
        [NameInMap("Eid")]
        [Validation(Required=false)]
        public string Eid { get; set; }

        /// <summary>
        /// <para>Specifies whether to grant local administrator permissions to users who use cloud desktops.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAdminAccess")]
        [Validation(Required=false)]
        public bool? EnableAdminAccess { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable public network access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableInternetAccess")]
        [Validation(Required=false)]
        public bool? EnableInternetAccess { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable trusted device verification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedVerifyZeroDevice")]
        [Validation(Required=false)]
        public bool? NeedVerifyZeroDevice { get; set; }

        /// <summary>
        /// <para>The name of the office network. The name must be 2 to 255 characters in length and can contain letters, digits, colons (:), underscores (_), and hyphens (-). The name must start with a letter or Chinese character and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestOfficeSite_Simple</para>
        /// </summary>
        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
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
        /// <para>The ID of the vSwitch in the VPC. This parameter is required when you create a CloudBox office network.</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public List<string> VSwitchId { get; set; }

        /// <summary>
        /// <para>The verification code. If the specified CEN instance belongs to another Alibaba Cloud account, call <a href="https://help.aliyun.com/document_detail/335132.html">SendVerifyCode</a> to obtain the verification code first.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("VerifyCode")]
        [Validation(Required=false)]
        public string VerifyCode { get; set; }

        /// <summary>
        /// <para>The type of the office network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("VpcType")]
        [Validation(Required=false)]
        public string VpcType { get; set; }

    }

}
