// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListArtifactBuildLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The log array.</para>
        /// </summary>
        [NameInMap("BuildLogs")]
        [Validation(Required=false)]
        public List<ListArtifactBuildLogsResponseBodyBuildLogs> BuildLogs { get; set; }
        public class ListArtifactBuildLogsResponseBodyBuildLogs : TeaModel {
            /// <summary>
            /// <para>The log content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NDAx</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The timestamp.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>1738894304</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page. The maximum value is 100 and the default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to start the next paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAVEKMJSB4yFi/EJc7fOJCkw=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>708AB976-F69C-5727-BED9-8C39D878B93A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
