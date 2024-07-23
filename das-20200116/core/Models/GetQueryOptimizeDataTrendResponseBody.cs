// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetQueryOptimizeDataTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The detailed information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQueryOptimizeDataTrendResponseBodyData Data { get; set; }
        public class GetQueryOptimizeDataTrendResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <para>The details of the trend data.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetQueryOptimizeDataTrendResponseBodyDataList> List { get; set; }
            public class GetQueryOptimizeDataTrendResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The name of the metric. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>sqlExecuteCount</b>: the number of executions of slow SQL queries.</description></item>
                /// <item><description><b>sqlExecuteCountDiff</b>: the difference in the number of executions of slow SQL queries compared to the previous day.</description></item>
                /// <item><description><b>sqlCount</b>: the number of slow SQL templates.</description></item>
                /// <item><description><b>sqlCountDiff</b>: the difference in the number of slow SQL templates compared to the previous day.</description></item>
                /// <item><description><b>optimizedSqlExecuteCount</b>: the number of optimizable executions of slow SQL queries.</description></item>
                /// <item><description><b>optimizedSqlExecuteCountDiff</b>: the difference in the number of optimizable executions of slow SQL queries compared to the previous day.</description></item>
                /// <item><description><b>optimizedSqlCount</b>: the number of optimizable slow SQL templates.</description></item>
                /// <item><description><b>optimizedSqlCountDiff</b>: the difference in the number of optimizable slow SQL templates compared to the previous day.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sqlExecuteCount</para>
                /// </summary>
                [NameInMap("Kpi")]
                [Validation(Required=false)]
                public string Kpi { get; set; }

                /// <summary>
                /// <para>The data timestamp. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1643040000000</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>The value of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

            /// <summary>
            /// <para>The reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>The reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

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

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
