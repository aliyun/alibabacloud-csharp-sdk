// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class QueryGateVerifyStatisticPublicResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If OK is returned, the request is successful.</description></item>
        /// <item><description>For more information about other error codes, see <a href="https://help.aliyun.com/document_detail/85198.html">API response codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about the calls of Phone Number Verification Service, including the total calls, the successful calls, failed calls, unknown calls, and daily calls within the statistical date range.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryGateVerifyStatisticPublicResponseBodyData Data { get; set; }
        public class QueryGateVerifyStatisticPublicResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the daily calls.</para>
            /// </summary>
            [NameInMap("DayStatistic")]
            [Validation(Required=false)]
            public List<QueryGateVerifyStatisticPublicResponseBodyDataDayStatistic> DayStatistic { get; set; }
            public class QueryGateVerifyStatisticPublicResponseBodyDataDayStatistic : TeaModel {
                /// <summary>
                /// <para>The date. This field is accurate to the day. The value of this field is in the YYYYMMDD format. Example: 20220103.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20220103</para>
                /// </summary>
                [NameInMap("StatisticDateStr")]
                [Validation(Required=false)]
                public string StatisticDateStr { get; set; }

                /// <summary>
                /// <para>The failed calls on the day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("TotalFail")]
                [Validation(Required=false)]
                public long? TotalFail { get; set; }

                /// <summary>
                /// <para>The successful calls on the day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalSuccess")]
                [Validation(Required=false)]
                public long? TotalSuccess { get; set; }

                /// <summary>
                /// <para>The unknown calls on the day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalUnknown")]
                [Validation(Required=false)]
                public long? TotalUnknown { get; set; }

            }

            /// <summary>
            /// <para>The total calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

            /// <summary>
            /// <para>The failed calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalFail")]
            [Validation(Required=false)]
            public long? TotalFail { get; set; }

            /// <summary>
            /// <para>The successful calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalSuccess")]
            [Validation(Required=false)]
            public long? TotalSuccess { get; set; }

            /// <summary>
            /// <para>The unknown calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalUnknown")]
            [Validation(Required=false)]
            public long? TotalUnknown { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8906582E-6722</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
