// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeBgpNetworksResponseBody : TeaModel {
        [NameInMap("BgpNetworks")]
        [Validation(Required=false)]
        public DescribeBgpNetworksResponseBodyBgpNetworks BgpNetworks { get; set; }
        public class DescribeBgpNetworksResponseBodyBgpNetworks : TeaModel {
            [NameInMap("BgpNetwork")]
            [Validation(Required=false)]
            public List<DescribeBgpNetworksResponseBodyBgpNetworksBgpNetwork> BgpNetwork { get; set; }
            public class DescribeBgpNetworksResponseBodyBgpNetworksBgpNetwork : TeaModel {
                [NameInMap("DstCidrBlock")]
                [Validation(Required=false)]
                public string DstCidrBlock { get; set; }

                [NameInMap("RouterId")]
                [Validation(Required=false)]
                public string RouterId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
