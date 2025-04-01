// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeBgpNetworksResponseBody : TeaModel {
        /// <summary>
        /// <para>BGP networks.</para>
        /// </summary>
        [NameInMap("BgpNetworks")]
        [Validation(Required=false)]
        public DescribeBgpNetworksResponseBodyBgpNetworks BgpNetworks { get; set; }
        public class DescribeBgpNetworksResponseBodyBgpNetworks : TeaModel {
            [NameInMap("BgpNetwork")]
            [Validation(Required=false)]
            public List<DescribeBgpNetworksResponseBodyBgpNetworksBgpNetwork> BgpNetwork { get; set; }
            public class DescribeBgpNetworksResponseBodyBgpNetworksBgpNetwork : TeaModel {
                /// <summary>
                /// <para>The CIDR block of the advertised BGP network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.1.XX.XX/24</para>
                /// </summary>
                [NameInMap("DstCidrBlock")]
                [Validation(Required=false)]
                public string DstCidrBlock { get; set; }

                /// <summary>
                /// <para>The ID of the VBR.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vrt-bp1lhl0taikrteen8****</para>
                /// </summary>
                [NameInMap("RouterId")]
                [Validation(Required=false)]
                public string RouterId { get; set; }

                /// <summary>
                /// <para>The status of the advertised BGP network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC) in which the master instance resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1qpo0kug3a2*****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6F513A15-669F-419D-B511-08A85292059B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of advertised BGP networks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
