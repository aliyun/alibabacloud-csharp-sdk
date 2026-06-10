// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateSimpleOfficeSiteRequest : TeaModel {
        [NameInMap("AccessAttribute")]
        [Validation(Required=false)]
        public string AccessAttribute { get; set; }

        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        [NameInMap("AuthorityHost")]
        [Validation(Required=false)]
        public string AuthorityHost { get; set; }

        /// <summary>
        /// <para>The peak public bandwidth. Valid values: 10 to 200. Unit: Mbps.
        /// This parameter is valid only when <c>EnableInternetAccess</c> is set to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The ID of the Cloud Enterprise Network (CEN) instance.</para>
        /// <remarks>
        /// <para>If you want to connect to cloud desktops over a VPC, attach the office site to the same CEN instance that is connected to your on-premises network by a VPN or an Express Connect circuit.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cen-3gwy16dojz1m65****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that owns the CEN instance.</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify CenId, or if the CEN instance belongs to your Alibaba Cloud account, this parameter is not required.</para>
        /// </description></item>
        /// <item><description><para>If the CEN instance is owned by another Alibaba Cloud account, specify the ID of that account.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>118272523431****</para>
        /// </summary>
        [NameInMap("CenOwnerId")]
        [Validation(Required=false)]
        public long? CenOwnerId { get; set; }

        /// <summary>
        /// <para>The IPv4 CIDR block for the office site\&quot;s Virtual Private Cloud (VPC). This parameter is required for standard office sites. The system automatically creates a VPC based on the specified IPv4 CIDR block. Use one of the following CIDR blocks or their subnets:</para>
        /// <list type="bullet">
        /// <item><description><para><c>10.0.0.0/12</c> (The valid mask range is 12 to 24 bits.)</para>
        /// </description></item>
        /// <item><description><para><c>172.16.0.0/12</c> (The valid mask range is 12 to 24 bits.)</para>
        /// </description></item>
        /// <item><description><para><c>192.168.0.0/16</c> (The valid mask range is 16 to 24 bits.)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.0/12</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("ClientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// <para>Specifies whether to create a Cloud Box office site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CloudBoxOfficeSite")]
        [Validation(Required=false)]
        public bool? CloudBoxOfficeSite { get; set; }

        /// <summary>
        /// <para>Specifies how clients can connect to cloud desktops.</para>
        /// <remarks>
        /// <para>VPC connections rely on the Alibaba Cloud PrivateLink service, which is free of charge. If you set this parameter to <c>VPC</c> or <c>Any</c>, the system automatically enables the PrivateLink service.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("DesktopAccessType")]
        [Validation(Required=false)]
        public string DesktopAccessType { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("Eid")]
        [Validation(Required=false)]
        public string Eid { get; set; }

        /// <summary>
        /// <para>Specifies whether to grant users local administrator privileges on their cloud desktops.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAdminAccess")]
        [Validation(Required=false)]
        public bool? EnableAdminAccess { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable internet access.</para>
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
        /// <para>The name of the office site. The name must be 2 to 255 characters in length. It must start with a letter or a Chinese character, and cannot start with <c>http://</c> or <c>https://</c>. The name can contain digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestOfficeSite_Simple</para>
        /// </summary>
        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to get a list of regions that support Elastic Desktop Service (ECD).</para>
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

        /// <summary>
        /// <para>The vSwitch ID. This parameter is required when you create a Cloud Box office site.</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public List<string> VSwitchId { get; set; }

        /// <summary>
        /// <para>The verification code. If the CEN instance is owned by another Alibaba Cloud account, you must first call <a href="https://help.aliyun.com/document_detail/335132.html">SendVerifyCode</a> to obtain a verification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("VerifyCode")]
        [Validation(Required=false)]
        public string VerifyCode { get; set; }

        /// <summary>
        /// <para>The type of the office site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("VpcType")]
        [Validation(Required=false)]
        public string VpcType { get; set; }

    }

}
