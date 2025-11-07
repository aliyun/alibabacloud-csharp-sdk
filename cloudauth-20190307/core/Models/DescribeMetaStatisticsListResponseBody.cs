// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeMetaStatisticsListResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeMetaStatisticsListResponseBodyItems> Items { get; set; }
        public class DescribeMetaStatisticsListResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>MOBILE_ONLINE_LENGTH</para>
            /// </summary>
            [NameInMap("Api")]
            [Validation(Required=false)]
            public string Api { get; set; }

            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BillCount")]
            [Validation(Required=false)]
            public long? BillCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BillRate")]
            [Validation(Required=false)]
            public string BillRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ChargeCount")]
            [Validation(Required=false)]
            public long? ChargeCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11/8</para>
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CUCC</para>
            /// </summary>
            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NoRecordCount")]
            [Validation(Required=false)]
            public long? NoRecordCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("PassedCount")]
            [Validation(Required=false)]
            public long? PassedCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PassedRate")]
            [Validation(Required=false)]
            public string PassedRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public long? SuccessCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SuccessRate")]
            [Validation(Required=false)]
            public string SuccessRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("UnpassedCount")]
            [Validation(Required=false)]
            public long? UnpassedCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3F860B3F-76B7-5555-A907-2F4433BF8868</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
