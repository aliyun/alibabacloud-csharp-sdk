// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterLogsResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<DescribeClusterLogsResponseBody> Body { get; set; }
        public class DescribeClusterLogsResponseBody : TeaModel {
            /// <summary>
            /// <para>The ID of the log entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>590749245</para>
            /// </summary>
            [NameInMap("ID")]
            [Validation(Required=false)]
            public long? ID { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c23421cfa74454bc8b37163fd19af***</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The log content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>start to update cluster status to CREATE_COMPLETE</para>
            /// </summary>
            [NameInMap("cluster_log")]
            [Validation(Required=false)]
            public string ClusterLog { get; set; }

            /// <summary>
            /// <para>The time when the log entry was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-11T10:11:51+08:00</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The time when the log entry was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-11T10:11:51+08:00</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
