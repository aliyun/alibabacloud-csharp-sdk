// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVirtualBorderRoutersForPhysicalConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The filter keys.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeVirtualBorderRoutersForPhysicalConnectionRequestFilter> Filter { get; set; }
        public class DescribeVirtualBorderRoutersForPhysicalConnectionRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter conditions. You can specify at most five filter conditions. The following filter conditions are supported:</para>
            /// <list type="bullet">
            /// <item><description><b>PhysicalConnectionId</b>: filter VBRs by the Express Connect circuit ID.</description></item>
            /// <item><description><b>VbrId</b>: filter VBRs by ID.</description></item>
            /// <item><description><b>Status</b>: filter VBRs by status.</description></item>
            /// <item><description><b>Name</b>: filter VBRs by name.</description></item>
            /// <item><description><b>AccessPointId</b>: filter VBRs by access point ID.</description></item>
            /// <item><description><b>eccId</b>: filter VBRs by ID of Express Cloud Connect (ECC) instance.</description></item>
            /// <item><description><b>type</b>: filter VBRs by type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Status</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value for the key. You can specify multiple filter values for one key. The logical operator among filter values is OR. If one filter value is matched, the filter condition is matched.</para>
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
        /// <para>The number of entries per page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
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
        /// <para>The region in which the Express Connect circuit is deployed. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to obtain the region ID.</para>
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
