// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNatGatewaysResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the NAT gateways.</para>
        /// </summary>
        [NameInMap("NatGateways")]
        [Validation(Required=false)]
        public List<DescribeNatGatewaysResponseBodyNatGateways> NatGateways { get; set; }
        public class DescribeNatGatewaysResponseBodyNatGateways : TeaModel {
            /// <summary>
            /// <para>The time when the NAT gateway was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-22T07:03:32Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the ENS node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-xiangyang-5</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The name of the NAT gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test0</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the NAT gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nat-5t7nh1cfm6kxiszlttr38****</para>
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// <para>The ID of the network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n-5s2ml1olj0kzaws9n1yrj****</para>
            /// </summary>
            [NameInMap("NetworkId")]
            [Validation(Required=false)]
            public string NetworkId { get; set; }

            /// <summary>
            /// <para>The type of the NAT gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enat.default</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-5szpp1os9m55myirbflfw****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2818A8F4-5E2B-5611-8732-5ACF7B677059</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of NAT gateways that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
