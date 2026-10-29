// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The list of cloud computer template IDs.</para>
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public List<string> BundleId { get; set; }

        /// <summary>
        /// <para>The ID of the shared cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-2i8qxpv6t1a03****</para>
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// <para>The list of shared cloud computer IDs.</para>
        /// </summary>
        [NameInMap("DesktopGroupIds")]
        [Validation(Required=false)]
        public List<string> DesktopGroupIds { get; set; }

        /// <summary>
        /// <para>The name of the shared cloud computer to query. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudComputerPool01</para>
        /// </summary>
        [NameInMap("DesktopGroupName")]
        [Validation(Required=false)]
        public string DesktopGroupName { get; set; }

        /// <summary>
        /// <para>The cloud computer specification. You can call the <a href="~~DescribeDesktopTypes~~">DescribeDesktopTypes</a> operation to query the supported cloud computer specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.enterprise_office.16c64g</para>
        /// </summary>
        [NameInMap("DesktopType")]
        [Validation(Required=false)]
        public string DesktopType { get; set; }

        /// <summary>
        /// <para>The IDs of the authorized users of the shared cloud computer.</para>
        /// </summary>
        [NameInMap("EndUserIds")]
        [Validation(Required=false)]
        public List<string> EndUserIds { get; set; }

        /// <summary>
        /// <para>The list of authorized users to exclude.</para>
        /// </summary>
        [NameInMap("ExcludedEndUserIds")]
        [Validation(Required=false)]
        public List<string> ExcludedEndUserIds { get; set; }

        /// <summary>
        /// <para>The list of image IDs.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public List<string> ImageId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page in a paging query.
        /// Maximum value: 100.
        /// Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Specifies whether the shared cloud computer is of the multi-resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MultiResource")]
        [Validation(Required=false)]
        public bool? MultiResource { get; set; }

        /// <summary>
        /// <para>The token that is used to start the next query. An empty value indicates that no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the office network to which the shared cloud computer belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-467671****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The type of the shared cloud computer.</para>
        /// <remarks>
        /// <para>This parameter is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OwnType")]
        [Validation(Required=false)]
        public long? OwnType { get; set; }

        /// <summary>
        /// <para>The subscription duration of the shared cloud computer. The unit is specified by <c>PeriodUnit</c>.</para>
        /// <list type="bullet">
        /// <item><description>If <c>PeriodUnit</c> is set to <c>Month</c>, valid values are:<list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// <item><description>6</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If <c>PeriodUnit</c> is set to <c>Year</c>, valid values are:<list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// <item><description>4</description></item>
        /// <item><description>5</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of duration for the subscription Billable methods.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The ID of the policy associated with the shared cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-53iyi2aar0nd6****</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

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
        /// <para>The ID of the QoS rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-5605u0gelk200****</para>
        /// </summary>
        [NameInMap("QosRuleId")]
        [Validation(Required=false)]
        public string QosRuleId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the list of regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The status of the shared cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The list of tags. You can specify 1 to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDesktopGroupsRequestTag> Tag { get; set; }
        public class DescribeDesktopGroupsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key cannot be an empty string. It can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be an empty string. It can be up to 128 characters in length, and cannot start with <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
