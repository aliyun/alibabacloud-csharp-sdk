// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListTasksShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The range of task end time. You can specify this parameter to filter tasks that end within the specified range.</para>
        /// </summary>
        [NameInMap("EndTimeRange")]
        [Validation(Required=false)]
        public string EndTimeRangeShrink { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. Valid value range: (0, 100]. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// <para>The pagination token is used in the next request to retrieve a new page of results if the total number of results exceeds the value of the MaxResults parameter. The next call to the operation returns results lexicographically after the NextToken parameter value.</para>
        /// <remarks>
        /// <para> Leave this parameter empty in your first call to the operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg6aW1tdGVzdDpleGFtcGxlYnVja2V0OmRhdGFzZXQwMDE6b3NzOi8vZXhhbXBsZWJ1Y2tldC9zYW1wbGVvYmplY3QxLmpwZw==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: sorts the results in ascending order. This is the default sort order.</description></item>
        /// <item><description>DES: sorts the results in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The name of the project.<a href="~~478153~~"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Specifies whether to return request parameters in the initial request to create the task. Default value: False.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("RequestDefinition")]
        [Validation(Required=false)]
        public bool? RequestDefinition { get; set; }

        /// <summary>
        /// <para>The field used to sort the results by. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TaskId: sorts the results by task ID. This is the default sort field.</description></item>
        /// <item><description>StartTime: sorts the results by task start time.</description></item>
        /// <item><description>StartTime: sorts the results by task end time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TaskId</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The range of task start time. You can specify this parameter to filter tasks that start within the specified range.</para>
        /// </summary>
        [NameInMap("StartTimeRange")]
        [Validation(Required=false)]
        public string StartTimeRangeShrink { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Running: The task is running.</description></item>
        /// <item><description>Succeeded: The task is successful.</description></item>
        /// <item><description>Failed: The task failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The custom tags of tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test=val1</para>
        /// </summary>
        [NameInMap("TagSelector")]
        [Validation(Required=false)]
        public string TagSelector { get; set; }

        /// <summary>
        /// <para>The task types.</para>
        /// </summary>
        [NameInMap("TaskTypes")]
        [Validation(Required=false)]
        public string TaskTypesShrink { get; set; }

    }

}
