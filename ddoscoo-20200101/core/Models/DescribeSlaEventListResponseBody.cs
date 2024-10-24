// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeSlaEventListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The destination rate limit events.</para>
        /// </summary>
        [NameInMap("SlaEvent")]
        [Validation(Required=false)]
        public List<DescribeSlaEventListResponseBodySlaEvent> SlaEvent { get; set; }
        public class DescribeSlaEventListResponseBodySlaEvent : TeaModel {
            /// <summary>
            /// <para>The end of the time range. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1671886740</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.107.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The region to which the destination IP address belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cn</b>: a region in the Chinese mainland</description></item>
            /// <item><description><b>cn-hongkong</b>: China (Hong Kong)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The beginning of the time range. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1678080840</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
