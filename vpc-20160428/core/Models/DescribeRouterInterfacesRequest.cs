// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouterInterfacesRequest : TeaModel {
        /// <summary>
        /// <para>The filter information.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeRouterInterfacesRequestFilter> Filter { get; set; }
        public class DescribeRouterInterfacesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter condition. You can specify up to 5 filter conditions. The following filter conditions are supported:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RouterInterfaceId</b>: the router interface ID.</para>
            /// </description></item>
            /// <item><description><para><b>RouterId</b>: the router ID.</para>
            /// </description></item>
            /// <item><description><para><b>RouterType</b>: the router type. Valid values: <b>VRouter</b> and <b>VBR</b>.</para>
            /// </description></item>
            /// <item><description><para><b>RouterInterfaceOwnerId</b>: the ID of the account that owns the router interface.</para>
            /// </description></item>
            /// <item><description><para><b>OppositeInterfaceId</b>: the peer router interface ID.</para>
            /// </description></item>
            /// <item><description><para><b>OppositeRouterType</b>: the peer router interface type. Valid values: <b>VRouter</b> and <b>VBR</b>.</para>
            /// </description></item>
            /// <item><description><para><b>OppositeRouterId</b>: the peer router interface ID.</para>
            /// </description></item>
            /// <item><description><para><b>OppositeInterfaceOwnerId</b>: the ID of the account that owns the peer router interface.</para>
            /// </description></item>
            /// <item><description><para><b>Status</b>: the router interface status.</para>
            /// </description></item>
            /// <item><description><para><b>Name</b>: the router interface name.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Multiple values for a filter condition are evaluated by using the OR operator. A result is returned if any of the values match. Filter conditions are evaluated by using the AND operator. A result is returned only if all filter conditions are matched.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Filter.1.Status</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value based on the specified Key. You can specify multiple filter values for a Key. Multiple filter values are evaluated by using the OR operator. A result is returned if any of the filter values match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Filter.1.Active 1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to include renewal data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeReservationData")]
        [Validation(Required=false)]
        public bool? IncludeReservationData { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging queries. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the router interface.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/2381067.html">What is a resource group?</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeRouterInterfacesRequestTags> Tags { get; set; }
        public class DescribeRouterInterfacesRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You must specify at least 1 tag key and can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
