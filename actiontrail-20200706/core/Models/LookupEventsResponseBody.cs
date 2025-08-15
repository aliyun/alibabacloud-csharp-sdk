// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class LookupEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The end of the time range when event details were queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-07-22T14:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The returned event details.</para>
        /// <para>For more information about the fields in an event log, see <a href="https://help.aliyun.com/document_detail/28819.html">ActionTrail event log reference</a>.</para>
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Events { get; set; }

        /// <summary>
        /// <para>The token used to return the next page of query results.</para>
        /// <remarks>
        /// <para>This parameter is not returned if no more results are to be returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhY2NvdW50IjoiMTQyNDM3OTU4NjM4NzE2MSIsImV2ZW50SWQiOiI3MkJDRTExRi02OTU3LTQ0NUItQjY0MC1CNEUyMkM4NUEwQzgiLCJsb2dJZCI6IjgyLTE0MjQzNzk1ODYzODcxNjEiLCJ0aW1lIjoxNjAyMzExNTQwMD****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FD79665A-CE8B-49D4-82E6-5EE2E0E791DD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range when event details were queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-07-15T14:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
