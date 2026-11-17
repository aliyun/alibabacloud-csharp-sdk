// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouterInterfacesRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeRouterInterfacesRequestFilter> Filter { get; set; }
        public class DescribeRouterInterfacesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter key. You can specify up to five filter keys. The following filter keys are supported:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RouterInterfaceId</b>: The ID of the router interface.</para>
            /// </description></item>
            /// <item><description><para><b>RouterId</b>: The ID of the router.</para>
            /// </description></item>
            /// <item><description><para><b>RouterType</b>: The type of the router. Valid values: <b>VRouter</b> and <b>VBR</b>.</para>
            /// </description></item>
            /// <item><description><para><b>RouterInterfaceOwnerId</b>: The ID of the Alibaba Cloud account to which the router interface belongs.</para>
            /// </description></item>
            /// <item><description><para><b>OppositeInterfaceId</b>: The ID of the peer router interface.</para>
            /// </description></item>
            /// <item><description><para><b>OppositeRouterType</b>: The type of the peer router. Valid values: <b>VRouter</b> and <b>VBR</b>.</para>
            /// </description></item>
            /// <item><description><para><b>OppositeRouterId</b>: The ID of the peer router.</para>
            /// </description></item>
            /// <item><description><para><b>OppositeInterfaceOwnerId</b>: The ID of the Alibaba Cloud account to which the peer router interface belongs.</para>
            /// </description></item>
            /// <item><description><para><b>Status</b>: The status of the router interface.</para>
            /// </description></item>
            /// <item><description><para><b>Name</b>: The name of the router interface.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Multiple values for a filter key are evaluated by using the OR operator. A resource matches the filter condition if it matches one of the values. Multiple filter keys are evaluated by using the AND operator. A resource is returned in the query result only if it matches all the specified filter conditions.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Filter.1.Status</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value specified for the filter key. You can specify multiple filter values for a filter key. Multiple filter values are evaluated by using the OR operator. A resource matches the filter condition if it matches one of the filter values.</para>
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
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): No.</para>
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
        /// <para>The number of entries per page in a paging query. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the router interface.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
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
            /// <para>The tag key of the resource. You must specify at least one tag key and can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>A tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>A tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
