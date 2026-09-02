// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class QueryEventHouseWithTimeRangeResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code of the operation. Success indicates a successful call. Other values indicate specific error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The structured result data returned by the SQL query.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEventHouseWithTimeRangeResponseBodyData Data { get; set; }
        public class QueryEventHouseWithTimeRangeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of result rows returned by the SQL query.</para>
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public List<Row> Rows { get; set; }

            /// <summary>
            /// <para>The number of result rows actually returned by the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>A success message if the call succeeds, or a specific error message if the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. You can use this ID for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34AD682D-5B91-5773-8132-AA38C130****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates success. A value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
