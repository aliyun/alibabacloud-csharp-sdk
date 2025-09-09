// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceBuildLogsResponseBody : TeaModel {
        [NameInMap("BuildLogs")]
        [Validation(Required=false)]
        public List<ListServiceBuildLogsResponseBodyBuildLogs> BuildLogs { get; set; }
        public class ListServiceBuildLogsResponseBodyBuildLogs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>BuildArtifact</para>
            /// </summary>
            [NameInMap("BuildStep")]
            [Validation(Required=false)]
            public string BuildStep { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>build log</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yyyy-MM-dd\&quot;T\&quot;HH:mm:ss\&quot;Z\&quot;</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAW8kZY+u1sYOaYf5JmgmDQQ=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4DB0F536-B3BE-4F0D-BD29-E83FB56D550C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
