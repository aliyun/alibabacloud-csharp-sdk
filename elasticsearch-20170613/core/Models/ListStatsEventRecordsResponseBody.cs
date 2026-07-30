// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListStatsEventRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6DCC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListStatsEventRecordsResponseBodyResult Result { get; set; }
        public class ListStatsEventRecordsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The returned result.</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<ListStatsEventRecordsResponseBodyResultResult> Result { get; set; }
            public class ListStatsEventRecordsResponseBodyResultResult : TeaModel {
                /// <summary>
                /// <para>The number of events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("cnt")]
                [Validation(Required=false)]
                public string Cnt { get; set; }

                /// <summary>
                /// <para>The event level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Info</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The event status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Executed</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The event type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UserOperator</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public string Total { get; set; }

        }

    }

}
