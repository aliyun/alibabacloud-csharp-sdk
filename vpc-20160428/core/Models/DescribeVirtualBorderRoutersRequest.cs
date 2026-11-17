// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVirtualBorderRoutersRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeVirtualBorderRoutersRequestFilter> Filter { get; set; }
        public class DescribeVirtualBorderRoutersRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter key. You can specify up to five filter keys. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PhysicalConnectionId</b>: instance ID of the Express Connect circuit.</para>
            /// </description></item>
            /// <item><description><para><b>VbrId</b>: instance ID of the VBR.</para>
            /// </description></item>
            /// <item><description><para><b>Status</b>: the status of the VBR.</para>
            /// </description></item>
            /// <item><description><para><b>Name</b>: the name of the VBR.</para>
            /// </description></item>
            /// <item><description><para><b>AccessPointId</b>: instance ID of the access point.</para>
            /// </description></item>
            /// <item><description><para><b>eccId</b>: instance ID of the Express Cloud Connect instance.</para>
            /// </description></item>
            /// <item><description><para><b>type</b>: the type of the Express Connect circuit.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Status</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value corresponding to the filter key. You can specify multiple filter values for a single filter key. The filter values have an OR relationship. If a resource matches one of the filter values, it matches the filter condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to include VBRs that belong to other Alibaba Cloud accounts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: includes VBRs that belong to other accounts.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): does not include VBRs that belong to other accounts.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeCrossAccountVbr")]
        [Validation(Required=false)]
        public bool? IncludeCrossAccountVbr { get; set; }

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
        /// <para>The number of entries to return on each page in a paging query. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the VBR. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94475.html">What is a resource group?</a>.</para>
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
        public List<DescribeVirtualBorderRoutersRequestTags> Tags { get; set; }
        public class DescribeVirtualBorderRoutersRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You must specify at least one tag key and can specify up to 20 tag keys. The tag key cannot be an empty string. A tag key can be up to 128 characters in length, cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string. A tag value can be up to 128 characters in length, cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
