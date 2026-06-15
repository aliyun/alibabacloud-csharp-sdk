// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRouterInterfacesRequest : TeaModel {
        /// <summary>
        /// <para>The filters.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeRouterInterfacesRequestFilter> Filter { get; set; }
        public class DescribeRouterInterfacesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter key. Supported values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>RouterInterfaceId</c>: The ID of the router interface.</para>
            /// </description></item>
            /// <item><description><para><c>RouterId</c>: The ID of the router that the router interface is attached to.</para>
            /// </description></item>
            /// <item><description><para><c>RouterType</c>: The type of the router. Valid values: <c>VRouter</c> and <c>VBR</c>.</para>
            /// </description></item>
            /// <item><description><para><c>Status</c>: The status of the router interface.</para>
            /// </description></item>
            /// <item><description><para><c>Name</c>: The name of the router interface.</para>
            /// </description></item>
            /// <item><description><para><c>Role</c>: The role of the router interface. Valid values: <c>InitiatingSide</c> and <c>AcceptingSide</c>.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The values for the filter key. You can specify a maximum of 20 values.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Page numbering starts from 1.</para>
        /// <para>Default: 1.</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default: 10.</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call the <c>DescribeRegions</c> operation to get the latest list of regions.</para>
        /// <para>This parameter is required.</para>
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
