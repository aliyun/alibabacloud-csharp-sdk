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
            /// <para>The start time of the subinterval. The value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// <para>The time interval follows the left-closed, right-open principle. The interval includes the start time but excludes the end time. If the values of from and to are the same, the interval is invalid and the function returns an error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1409529600</para>
            /// </summary>
            [NameInMap("from")]
            [Validation(Required=false)]
            public long? From { get; set; }

            /// <summary>
            /// <para>The end time of the subinterval. The value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// <para>The time interval follows the left-closed, right-open principle. The interval includes the start time but excludes the end time. If the values of from and to are the same, the interval is invalid and the function returns an error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1409569200</para>
            /// </summary>
            [NameInMap("to")]
            [Validation(Required=false)]
            public long? To { get; set; }

            /// <summary>
            /// <para>The number of logs queried in the subinterval.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>Indicates whether the query results in the subinterval are complete.</para>
            /// <para>Complete: The query is complete and the returned results are complete.</para>
            /// <para>Incomplete: The query is complete but the returned results are incomplete. Repeat the request to obtain complete results.</para>
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
