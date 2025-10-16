// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallAccessDetailResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallAccessDetailResponseBodyDataList> DataList { get; set; }
        public class DescribeVpcFirewallAccessDetailResponseBodyDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>17845821669.0</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1123</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10.125.1.XX</para>
            /// </summary>
            [NameInMap("PeerAssetIP")]
            [Validation(Required=false)]
            public string PeerAssetIP { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-123451</para>
            /// </summary>
            [NameInMap("PeerAssetInstanceId")]
            [Validation(Required=false)]
            public string PeerAssetInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("PeerAssetInstanceName")]
            [Validation(Required=false)]
            public string PeerAssetInstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-123411</para>
            /// </summary>
            [NameInMap("PeerVpcId")]
            [Validation(Required=false)]
            public string PeerVpcId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-test</para>
            /// </summary>
            [NameInMap("peerVpcName")]
            [Validation(Required=false)]
            public string PeerVpcName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8EAC2347-E85A-5DFF-9F49-B8E1BAFB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
