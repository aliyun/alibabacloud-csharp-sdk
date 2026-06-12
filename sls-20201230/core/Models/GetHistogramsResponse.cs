// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetHistogramsResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<GetHistogramsResponseBody> Body { get; set; }
        public class GetHistogramsResponseBody : TeaModel {
            /// <summary>
            /// <para>The beginning of the time range for the subinterval. The value is a UNIX timestamp that represents the number of seconds that have elapsed since 1970-01-01 00:00:00 UTC.</para>
            /// <para>The time range is a left-closed, right-open interval. This means that the subinterval includes the start time but not the end time. If the values of from and to are the same, the interval is invalid and an error is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1409529600</para>
            /// </summary>
            [NameInMap("from")]
            [Validation(Required=false)]
            public long? From { get; set; }

            /// <summary>
            /// <para>The end of the time range for the subinterval. The value is a UNIX timestamp that represents the number of seconds that have elapsed since 1970-01-01 00:00:00 UTC.</para>
            /// <para>The time range is a left-closed, right-open interval. This means that the subinterval includes the start time but not the end time. If the values of from and to are the same, the interval is invalid and an error is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1409569200</para>
            /// </summary>
            [NameInMap("to")]
            [Validation(Required=false)]
            public long? To { get; set; }

            /// <summary>
            /// <para>The number of logs that are found in the subinterval.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>Indicates whether the query result in the subinterval is complete.</para>
            /// <para>Complete: The query is complete and the result is complete.</para>
            /// <para>Incomplete: The query is complete but the result is incomplete. Send the request again to obtain the complete result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Complete</para>
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

        }

    }

}
