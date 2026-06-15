// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeHaVipsRequest : TeaModel {
        /// <summary>
        /// <para>The query filters. You can specify 1 to 20 filters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeHaVipsRequestFilter> Filter { get; set; }
        public class DescribeHaVipsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter key. Valid values:</para>
            /// <para><c>HaVipId</c>: The ID of the high-availability virtual IP (HAVIP).</para>
            /// <para><c>HaVipName</c>: The name of the HAVIP.</para>
            /// <para><c>VpcId</c>: The ID of the VPC to which the HAVIP belongs.</para>
            /// <para><c>VSwitchId</c>: The ID of the vSwitch to which the HAVIP belongs.</para>
            /// <para><c>IpAddress</c>: The IP address of the HAVIP.</para>
            /// <para><c>AssociatedInstanceType</c>: The type of instance associated with the HAVIP. The value must be <c>EcsInstance</c>.</para>
            /// <para><c>AssociatedInstanceId</c>: The ID of the instance associated with the HAVIP.</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>A list of 1 to 20 values.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 50. Default value: 10.</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
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
