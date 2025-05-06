// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListLogContentsResponseBody : TeaModel {
        /// <summary>
        /// <para>Log content.</para>
        /// </summary>
        [NameInMap("listLogContent")]
        [Validation(Required=false)]
        public ListLogContentsResponseBodyListLogContent ListLogContent { get; set; }
        public class ListLogContentsResponseBodyListLogContent : TeaModel {
            /// <summary>
            /// <para>List of log line contents.</para>
            /// </summary>
            [NameInMap("contents")]
            [Validation(Required=false)]
            public List<ListLogContentsResponseBodyListLogContentContents> Contents { get; set; }
            public class ListLogContentsResponseBodyListLogContentContents : TeaModel {
                /// <summary>
                /// <para>Log line content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spark pi is 3.14\n</para>
                /// </summary>
                [NameInMap("LineContent")]
                [Validation(Required=false)]
                public string LineContent { get; set; }

            }

            /// <summary>
            /// <para>Total number of log lines.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalLength")]
            [Validation(Required=false)]
            public long? TotalLength { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
