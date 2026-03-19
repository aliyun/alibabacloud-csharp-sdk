// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListStatsEventRecordsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6DCC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListStatsEventRecordsResponseBodyResult Result { get; set; }
        public class ListStatsEventRecordsResponseBodyResult : TeaModel {
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<ListStatsEventRecordsResponseBodyResultResult> Result { get; set; }
            public class ListStatsEventRecordsResponseBodyResultResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("cnt")]
                [Validation(Required=false)]
                public string Cnt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Info</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Executed</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>UserOperator</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public string Total { get; set; }

        }

    }

}
