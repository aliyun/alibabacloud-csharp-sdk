// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlLogStatisticResponseBodyData Data { get; set; }
        public class DescribeSqlLogStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The size of the SQL Explorer and Audit data that is stored in cold storage. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8585901</para>
            /// </summary>
            [NameInMap("ColdSqlSize")]
            [Validation(Required=false)]
            public long? ColdSqlSize { get; set; }

            /// <summary>
            /// <para>The free quota for cold data storage. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5041450</para>
            /// </summary>
            [NameInMap("FreeColdSqlSize")]
            [Validation(Required=false)]
            public long? FreeColdSqlSize { get; set; }

            /// <summary>
            /// <para>The free quota for hot data storage. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>297245</para>
            /// </summary>
            [NameInMap("FreeHotSqlSize")]
            [Validation(Required=false)]
            public long? FreeHotSqlSize { get; set; }

            /// <summary>
            /// <para>The size of the SQL Explorer and Audit data that is stored in hot storage. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1118042</para>
            /// </summary>
            [NameInMap("HotSqlSize")]
            [Validation(Required=false)]
            public long? HotSqlSize { get; set; }

            /// <summary>
            /// <para>The size of the SQL Explorer and Audit data that was generated in the most recent day. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("ImportSqlSize")]
            [Validation(Required=false)]
            public long? ImportSqlSize { get; set; }

            /// <summary>
            /// <para>The timestamp. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1712568564928</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            [NameInMap("TotalSqlSize")]
            [Validation(Required=false)]
            public long? TotalSqlSize { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message is returned.</para>
        /// </remarks>
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
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
