// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallCenSummaryListResponseBody : TeaModel {
        [NameInMap("CenList")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallCenSummaryListResponseBodyCenList> CenList { get; set; }
        public class DescribeVpcFirewallCenSummaryListResponseBodyCenList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cen-maqfw3abcmjy56****</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("CenName")]
            [Validation(Required=false)]
            public string CenName { get; set; }

            [NameInMap("RegionNoList")]
            [Validation(Required=false)]
            public List<string> RegionNoList { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>432D6CCA-5186-5B91-A2B8-10C8994B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
