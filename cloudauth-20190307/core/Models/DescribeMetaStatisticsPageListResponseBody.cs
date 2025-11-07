// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeMetaStatisticsPageListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeMetaStatisticsPageListResponseBodyItems> Items { get; set; }
        public class DescribeMetaStatisticsPageListResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Api。</para>
            /// 
            /// <b>Example:</b>
            /// <para>ID_PERIOD</para>
            /// </summary>
            [NameInMap("Api")]
            [Validation(Required=false)]
            public string Api { get; set; }

            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("BillCount")]
            [Validation(Required=false)]
            public long? BillCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("BillRate")]
            [Validation(Required=false)]
            public string BillRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
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
            /// <para>CMCC</para>
            /// </summary>
            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("NoRecordCount")]
            [Validation(Required=false)]
            public long? NoRecordCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("PassedCount")]
            [Validation(Required=false)]
            public long? PassedCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C379C9E4-4DA0-5D0B-821B-25E2B8693D48</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
