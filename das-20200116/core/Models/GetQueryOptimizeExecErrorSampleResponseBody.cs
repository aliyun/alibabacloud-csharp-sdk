// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetQueryOptimizeExecErrorSampleResponseBody : TeaModel {
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
        public GetQueryOptimizeExecErrorSampleResponseBodyData Data { get; set; }
        public class GetQueryOptimizeExecErrorSampleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <para>The queried data.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetQueryOptimizeExecErrorSampleResponseBodyDataList> List { get; set; }
            public class GetQueryOptimizeExecErrorSampleResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testdb01</para>
                /// </summary>
                [NameInMap("Dbname")]
                [Validation(Required=false)]
                public string Dbname { get; set; }

                /// <summary>
                /// <para>The error code returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1146</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The IP address of the client that executes the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.104.XX.XX</para>
                /// </summary>
                [NameInMap("OrigHost")]
                [Validation(Required=false)]
                public string OrigHost { get; set; }

                /// <summary>
                /// <para>The SQL template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2e8147b5ca2dfc640dfd5e43d96a****</para>
                /// </summary>
                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                /// <summary>
                /// <para>The content of the SQL statement that failed to be executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select * from test1</para>
                /// </summary>
                [NameInMap("SqlText")]
                [Validation(Required=false)]
                public string SqlText { get; set; }

                /// <summary>
                /// <para>The point in time when the failed SQL statement was executed. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1643020306739</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>The username of the client that executes the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test01</para>
                /// </summary>
                [NameInMap("User")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            /// <summary>
            /// <para>A reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>A reserved parameter.</para>
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
            /// <para>2</para>
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
