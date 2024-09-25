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
            /// <para>The filter conditions. You can specify up to five filter conditions. The following filter conditions are supported:</para>
            /// <list type="bullet">
            /// <item><description><b>RouterInterfaceId</b>: the ID of the router interface.</description></item>
            /// <item><description><b>RouterId</b>: the ID of the router.</description></item>
            /// <item><description><b>RouterType</b>: the router type. Valid values: <b>VRouter</b> and <b>VBR</b>.</description></item>
            /// <item><description><b>RouterInterfaceOwnerId</b>: the ID of the Alibaba Cloud account to which the router interface belongs.</description></item>
            /// <item><description><b>OppositeInterfaceId</b>: the ID of the peer router interface.</description></item>
            /// <item><description><b>OppositeRouterType</b>: the type of the peer router interface. Valid values: <b>VRouter</b> and <b>VBR</b>.</description></item>
            /// <item><description><b>OppositeRouterId</b>: the ID of the peer router.</description></item>
            /// <item><description><b>OppositeInterfaceOwnerId</b>: the ID of the Alibaba Cloud account to which the peer router interface belongs.</description></item>
            /// <item><description><b>Status</b>: the status of the router interface.</description></item>
            /// <item><description><b>Name</b>: the name of the router interface.</description></item>
            /// </list>
            /// <remarks>
            /// <para> The logical operator among multiple values in a filter condition is OR. In this case, the filter condition is met if one of the values is matched. The logical operator among filter conditions is AND. Only routers that meet all the filter conditions are queried.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Filter.1.Status</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Specifies the value in the filter condition based on the key. You can specify multiple filter values for one key. The logical operator among filter values is OR. If one filter value is matched, the filter condition is matched.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Filter.1.Active 1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether renewal data is included. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
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
        /// <para>The number of entries per page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the router interface.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource Group ID.</para>
        /// <para>For more information about resource groups, please refer to <a href="https://help.aliyun.com/document_detail/94475.html">What is a Resource Group?</a></para>
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
            /// <para>The key of the resource tag. At least one tag key must be entered, and a maximum of 20 tag keys are supported. If this value needs to be passed in, it cannot be an empty string.</para>
            /// <para>A tag key can support up to 128 characters, cannot start with \&quot;aliyun\&quot; or \&quot;acs:\&quot;, and cannot contain \&quot;http://\&quot; or \&quot;https://\&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the resource tag. A maximum of 20 tag values can be entered. If this value needs to be passed in, an empty string can be entered.</para>
            /// <para>A maximum of 128 characters are supported, it cannot start with \&quot;aliyun\&quot; or \&quot;acs:\&quot;, and it cannot contain \&quot;http://\&quot; or \&quot;https://\&quot;.</para>
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
