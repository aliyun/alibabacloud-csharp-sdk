// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetMetaCompareIncrementDbOverviewResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of data returned by the API operation. For the element structure, see the descriptions of the child fields.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMetaCompareIncrementDbOverviewResponseBodyData Data { get; set; }
        public class GetMetaCompareIncrementDbOverviewResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the current metadata comparison job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100256</para>
            /// </summary>
            [NameInMap("compareJobId")]
            [Validation(Required=false)]
            public long? CompareJobId { get; set; }

            /// <summary>
            /// <para>The metadata version time corresponding to the current comparison.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-15T10:30:00Z</para>
            /// </summary>
            [NameInMap("curVersionTime")]
            [Validation(Required=false)]
            public string CurVersionTime { get; set; }

            /// <summary>
            /// <para>The number of partitions added compared to the last comparison.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("diffAddPartitionNum")]
            [Validation(Required=false)]
            public long? DiffAddPartitionNum { get; set; }

            /// <summary>
            /// <para>The number of tables added compared to the last comparison.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("diffAddTableNum")]
            [Validation(Required=false)]
            public long? DiffAddTableNum { get; set; }

            /// <summary>
            /// <para>The number of partitions deleted compared to the last comparison.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("diffDelPartitionNum")]
            [Validation(Required=false)]
            public long? DiffDelPartitionNum { get; set; }

            /// <summary>
            /// <para>The number of tables deleted compared to the last comparison.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("diffDelTableNum")]
            [Validation(Required=false)]
            public long? DiffDelTableNum { get; set; }

            /// <summary>
            /// <para>The number of partitions whose properties changed compared to the last comparison.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("diffModifyPartitionNum")]
            [Validation(Required=false)]
            public long? DiffModifyPartitionNum { get; set; }

            /// <summary>
            /// <para>The number of tables whose structure underwent schema evolution compared to the last comparison.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("diffModifyTableNum")]
            [Validation(Required=false)]
            public long? DiffModifyTableNum { get; set; }

            /// <summary>
            /// <para>The total number of differences at the partition level, which is the sum of the number of added, deleted, and modified partitions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("diffPartitionNum")]
            [Validation(Required=false)]
            public long? DiffPartitionNum { get; set; }

            /// <summary>
            /// <para>The total number of differences at the table level, which is the sum of the number of added, deleted, and modified tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("diffTableNum")]
            [Validation(Required=false)]
            public long? DiffTableNum { get; set; }

            /// <summary>
            /// <para>The metadata version time corresponding to the last comparison.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-14T10:30:00Z</para>
            /// </summary>
            [NameInMap("prevVersionTime")]
            [Validation(Required=false)]
            public string PrevVersionTime { get; set; }

        }

        /// <summary>
        /// <para>The fault message code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed. If the call fails, troubleshoot the issue based on errCode and errMessage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
