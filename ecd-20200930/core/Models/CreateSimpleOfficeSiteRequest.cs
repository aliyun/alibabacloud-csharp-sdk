// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateSimpleOfficeSiteRequest : TeaModel {
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        [NameInMap("AuthorityHost")]
        [Validation(Required=false)]
        public string AuthorityHost { get; set; }

        /// <summary>
        /// <para>The maximum public bandwidth. Value range: 10 to 200. Unit: Mbit/s. This parameter is available if you set <c>EnableInternetAccess</c> to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The Cloud Enterprise Network (CEN) instance ID.</para>
        /// <remarks>
        /// <para> If you want end users to connect to cloud computers from Alibaba Cloud Workspace clients over VPCs, you can attach the office network to a CEN instance. The CEN instance is the one that connects to your on-premises network over VPN Gateway or Express Connect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cen-3gwy16dojz1m65****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the Cloud Enterprise Network (CEN) instance belongs.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify the CenId parameter, or the CEN instance that is specified by the CenId parameter belongs to the current Alibaba Cloud account, skip this parameter.</description></item>
        /// <item><description>If you specify the CenId parameter and the CEN instance that you specify for the CenId parameter belongs to another Alibaba Cloud account, enter the ID of the Alibaba Cloud account.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>118272523431****</para>
        /// </summary>
        [NameInMap("CenOwnerId")]
        [Validation(Required=false)]
        public long? CenOwnerId { get; set; }

        /// <summary>
        /// <para>The IPv4 CIDR block that you want the office network to use in the virtual private cloud (VPC) of the office network. The system automatically creates a VPC for the office network based on the IPv4 CIDR block. We recommend that you set this parameter to one of the following CIDR blocks and their subnets:</para>
        /// <list type="bullet">
        /// <item><description><c>10.0.0.0/12</c> (subnet mask range: 12 to 14 bits)</description></item>
        /// <item><description><c>172.16.0.0/12</c> (subnet mask range: 12 to 24 bits)</description></item>
        /// <item><description><c>192.168.0.0/16</c> (subnet mask range: 16 to 24 bits)</description></item>
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
        /// <para>Specifies whether to create a CloudBox-based office network.</para>
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
        [NameInMap("CloudBoxOfficeSite")]
        [Validation(Required=false)]
        public bool? CloudBoxOfficeSite { get; set; }

        /// <summary>
        /// <para>The method to connect to cloud computers from Alibaba Cloud Workspace clients.</para>
        /// <remarks>
        /// <para> The VPC connection depends on Alibaba Cloud PrivateLink. You can use PrivateLink for free. When you set this parameter to VPC or Any, PrivateLink is automatically activated.````</para>
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
        /// <para>Specifies whether to grant the local administrator permissions to users that are authorized to use cloud computers in the office network.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default)</description></item>
        /// <item><description>false</description></item>
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
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>false (default)</para>
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
        /// <para>The office network name. The name must be 2 to 255 characters in length. It can contain digits, colons (:), underscores (_), and hyphens (-). It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestOfficeSite_Simple</para>
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

        /// <summary>
        /// <para>The IDs of the vSwitches that you want to specify in VPCs. This parameter is required only when you create CloudBox-based office networks.</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public List<string> VSwitchId { get; set; }

        /// <summary>
        /// <para>The verification code. If the CEN instance that you specify for the CenId parameter belongs to another Alibaba Cloud account, you must call the <a href="https://help.aliyun.com/document_detail/335132.html">SendVerifyCode</a> operation to obtain the verification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("VerifyCode")]
        [Validation(Required=false)]
        public string VerifyCode { get; set; }

        /// <summary>
        /// <para>The network type of the office network.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standard: advanced</description></item>
        /// <item><description>basic: basic</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("VpcType")]
        [Validation(Required=false)]
        public string VpcType { get; set; }

    }

}
