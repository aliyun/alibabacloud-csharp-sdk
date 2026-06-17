// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallCenSummaryListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of CEN instances.</para>
        /// </summary>
        [NameInMap("CenList")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallCenSummaryListResponseBodyCenList> CenList { get; set; }
        public class DescribeVpcFirewallCenSummaryListResponseBodyCenList : TeaModel {
            /// <summary>
            /// <para>The ID of the CEN instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-maqfw3abcmjy56****</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>The name of the CEN instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("CenName")]
            [Validation(Required=false)]
            public string CenName { get; set; }

            /// <summary>
            /// <para>The list of region IDs for the VPC border firewall.</para>
            /// </summary>
            [NameInMap("RegionNoList")]
            [Validation(Required=false)]
            public List<string> RegionNoList { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>432D6CCA-5186-5B91-A2B8-10C8994B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
