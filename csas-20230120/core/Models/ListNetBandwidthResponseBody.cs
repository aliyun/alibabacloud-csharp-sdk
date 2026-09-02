// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListNetBandwidthResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of bandwidth configurations.</para>
        /// </summary>
        [NameInMap("NetBandwidthList")]
        [Validation(Required=false)]
        public List<ListNetBandwidthResponseBodyNetBandwidthList> NetBandwidthList { get; set; }
        public class ListNetBandwidthResponseBodyNetBandwidthList : TeaModel {
            /// <summary>
            /// <para>The bandwidth value, in Mbps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-01 10:20:30</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the instance was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-02 15:00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1234567890</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>production-vpc</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The network type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6707286-A50E-57B1-B2CF-EFAC59E850D8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
