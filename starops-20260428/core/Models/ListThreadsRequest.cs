// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class ListThreadsRequest : TeaModel {
        /// <summary>
        /// <para>Filters the results. If this parameter is omitted, the operation returns all threads in the instance.</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public List<ListThreadsRequestFilter> Filter { get; set; }
        public class ListThreadsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter key. Supported values are title, workspace, and project.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>title</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value for the filter key.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to include threads created by missions.</para>
        /// </summary>
        [NameInMap("includeMission")]
        [Validation(Required=false)]
        public bool? IncludeMission { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. Maximum value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The status of the thread.</para>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The thread ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>thread-123123</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

    }

}
