// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVirtualBorderRoutersForPhysicalConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The list of filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeVirtualBorderRoutersForPhysicalConnectionRequestFilter> Filter { get; set; }
        public class DescribeVirtualBorderRoutersForPhysicalConnectionRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter condition. You can specify up to five filter conditions. Supported filter conditions:</para>
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
            /// <item><description><para><b>type</b>: the type of the VBR.</para>
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
            /// <para>The filter value corresponding to the filter condition. You can specify multiple filter values for a single filter condition. The filter values are evaluated by using the OR logical operator. If a resource matches one of the filter values, it matches the filter condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

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
        /// <para>The number of entries per page during paging in a paged query. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the Express Connect circuit.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-119mfj****</para>
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        /// <summary>
        /// <para>The region where the Express Connect circuit is located. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
