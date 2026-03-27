// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListThreadsRequest : TeaModel {
        [NameInMap("filter")]
        [Validation(Required=false)]
        public List<ListThreadsRequestFilter> Filter { get; set; }
        public class ListThreadsRequestFilter : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dukang-oxs-pre-obeqi</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;Type\&quot;: \&quot;primaryDoc\&quot;, \&quot;Id\&quot;: \&quot;01ZM8y7\&quot;, \&quot;Name\&quot;: \&quot;key\&quot;}, {\&quot;Type\&quot;: \&quot;text\&quot;, \&quot;Id\&quot;: \&quot;mHe1U1b\&quot;, \&quot;Name\&quot;: \&quot;value\&quot;}, {\&quot;Type\&quot;: \&quot;text\&quot;, \&quot;Id\&quot;: \&quot;rRIhpBs\&quot;, \&quot;Name\&quot;: u\&quot;\u4f5c\u7528\&quot;}]</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>thread_id01</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

    }

}
