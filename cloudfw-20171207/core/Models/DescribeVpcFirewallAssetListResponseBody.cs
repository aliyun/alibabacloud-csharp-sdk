// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallAssetListResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallAssetListResponseBodyDataList> DataList { get; set; }
        public class DescribeVpcFirewallAssetListResponseBodyDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>192.0.XX.XX</para>
            /// </summary>
            [NameInMap("AssetIP")]
            [Validation(Required=false)]
            public string AssetIP { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-hp3ez3rs9bxwt034****</para>
            /// </summary>
            [NameInMap("AssetInstanceId")]
            [Validation(Required=false)]
            public string AssetInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs-test</para>
            /// </summary>
            [NameInMap("AssetInstanceName")]
            [Validation(Required=false)]
            public string AssetInstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("IpsHitCnt")]
            [Validation(Required=false)]
            public long? IpsHitCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            [NameInMap("PortList")]
            [Validation(Required=false)]
            public List<string> PortList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RiskReason")]
            [Validation(Required=false)]
            public string RiskReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalBytes")]
            [Validation(Required=false)]
            public long? TotalBytes { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>924A6CCC-4EAD-5554-8AD0-45F5ED56****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
