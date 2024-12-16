// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopsRequest : TeaModel {
        /// <summary>
        /// <para>The billing method of the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the desktop group. If you specify the <c>DesktopId</c> parameter, ignore the <c>DesktopGroupId</c> parameter. If you do not specify the <c>DesktopId</c> parameter, specify the <c>DesktopGroupId</c> parameter in the call to request all IDs of the cloud desktops in the specified desktop group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-2i8qxpv6t1a03****</para>
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud desktops. You can specify 1 to 100 cloud desktop IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-gx2x1dhsmucyy****</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The name of the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDesktopName</para>
        /// </summary>
        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        /// <summary>
        /// <para>The status of the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DesktopStatus")]
        [Validation(Required=false)]
        public string DesktopStatus { get; set; }

        /// <summary>
        /// <para>The list of desktop status.</para>
        /// </summary>
        [NameInMap("DesktopStatusList")]
        [Validation(Required=false)]
        public List<string> DesktopStatusList { get; set; }

        /// <summary>
        /// <para>The new desktop type. You can call the <a href="~~DescribeDesktopTypes~~">DescribeDesktopTypes</a> operation to query the IDs of supported desktop types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.general.2c8g</para>
        /// </summary>
        [NameInMap("DesktopType")]
        [Validation(Required=false)]
        public string DesktopType { get; set; }

        /// <summary>
        /// <para>The ID of the directory, The ID is the same as the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-363353****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The IDs of the end users that are assigned the cloud desktop. You can specify 1 to 100 end user IDs.</para>
        /// <remarks>
        /// <para>Only one end user can use the cloud desktop at a time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public List<string> EndUserId { get; set; }

        /// <summary>
        /// <para>The IDs of the end users that are excluded from the end users that are assigned the cloud desktop. You can specify 1 to 100 end user IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>andy</para>
        /// </summary>
        [NameInMap("ExcludedEndUserId")]
        [Validation(Required=false)]
        public List<string> ExcludedEndUserId { get; set; }

        /// <summary>
        /// <para>The time when the subscription cloud desktop expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-31T15:59:59Z</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        [NameInMap("FillResourceGroup")]
        [Validation(Required=false)]
        public bool? FillResourceGroup { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter cloud desktops in the desktop group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FilterDesktopGroup")]
        [Validation(Required=false)]
        public bool? FilterDesktopGroup { get; set; }

        [NameInMap("GpuInstanceGroupId")]
        [Validation(Required=false)]
        public string GpuInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the desktop group.</para>
        /// <remarks>
        /// <para>The desktop group feature is in invitational preview. If you want to use this feature, submit a ticket.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dg-boyczi8enfyc5****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the images.</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public List<string> ImageId { get; set; }

        /// <summary>
        /// <para>The flag that is used to manage the cloud desktops.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoFlag</para>
        /// </summary>
        [NameInMap("ManagementFlag")]
        [Validation(Required=false)]
        public string ManagementFlag { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <list type="bullet">
        /// <item><description>Maximum value: 100</description></item>
        /// <item><description>Default value: 10</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the next query. If this parameter is left empty, all results are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-363353****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The name of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        /// <summary>
        /// <para>The progress when the cloud desktop was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OnlyDesktopGroup")]
        [Validation(Required=false)]
        public bool? OnlyDesktopGroup { get; set; }

        /// <summary>
        /// <para>The types of the OSs.</para>
        /// </summary>
        [NameInMap("OsTypes")]
        [Validation(Required=false)]
        public List<string> OsTypes { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system-all-enabled-policy</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// <para>The type of the protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASP</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        [NameInMap("QosRuleId")]
        [Validation(Required=false)]
        public string QosRuleId { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the information about image update of the cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("QueryFotaUpdate")]
        [Validation(Required=false)]
        public bool? QueryFotaUpdate { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-hb12mclyne09xw***</para>
        /// </summary>
        [NameInMap("SnapshotPolicyId")]
        [Validation(Required=false)]
        public string SnapshotPolicyId { get; set; }

        [NameInMap("SubPayType")]
        [Validation(Required=false)]
        public string SubPayType { get; set; }

        /// <summary>
        /// <para>The tags. A tag is a key-value pair that consists of a tag key and a tag value. Tags are used to identify resources. You can use tags to manage cloud desktops by group for easy searching and batch operations. For more information, see <a href="https://help.aliyun.com/document_detail/203781.html">Use tags to manage cloud desktops</a>.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDesktopsRequestTag> Tag { get; set; }
        public class DescribeDesktopsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag. If you specify the <c>Tag</c> parameter, you must also specify the <c>Key</c> parameter. The tag key can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>aliyun</c> or <c>acs:</c>. You cannot specify an empty string as a tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag value cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the end user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
