// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAgent20260801.Models
{
    public class ListMessagesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of timeline entries to return per page. The value must be a positive integer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Do not specify this parameter for the first request. For subsequent requests, use the value returned from the previous page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-next-token</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Filters messages by the specified run ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>run_example_001</para>
        /// </summary>
        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

    }

}
