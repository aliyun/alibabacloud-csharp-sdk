// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListWorkflowTasksRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range for filtering tasks by their creation time. Supports querying data from the last 90 days only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-07-15T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndOfCreateTime")]
        [Validation(Required=false)]
        public string EndOfCreateTime { get; set; }

        /// <summary>
        /// <para>A keyword for fuzzy matching against the TaskInput, such as a file name or Media ID. Max length: 32 characters.</para>
        /// </summary>
        [NameInMap("KeyText")]
        [Validation(Required=false)]
        public string KeyText { get; set; }

        /// <summary>
        /// <para>The maximum number of media workflow instances to return. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****<b><b><b><b><b>VRpbWUQARgBIpcBCgkA1bUtaAAAAAAKiQEDhAAAADFTMzg2NTY2NjU2MzM3NjU2NjYyMzkzMTYyMzI2MjYzNjY2</b></b></b></b></b></para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The start of the time range for filtering tasks by their creation time. Supports querying data from the last 90 days only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-07-12T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartOfCreateTime")]
        [Validation(Required=false)]
        public string StartOfCreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the workflow template.<a href="https://ims.console.aliyun.com/settings/workflow/list"></a></para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>b4fb044839815d4f2cd8</b></b></b></para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// <para>The name of the workflow template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-workflow-****</para>
        /// </summary>
        [NameInMap("WorkflowName")]
        [Validation(Required=false)]
        public string WorkflowName { get; set; }

    }

}
