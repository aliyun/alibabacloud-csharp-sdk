// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeOnceTaskRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The timestamp when the root task ends. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1651766520000</para>
        /// </summary>
        [NameInMap("EndTimeQuery")]
        [Validation(Required=false)]
        public long? EndTimeQuery { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the root task.</para>
        /// <remarks>
        /// <para>You must specify at least one of the <b>TaskType</b> and <b>RootTaskId</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>bb5d657479bba5e1d308b6c9e85c9174</para>
        /// </summary>
        [NameInMap("RootTaskId")]
        [Validation(Required=false)]
        public string RootTaskId { get; set; }

        /// <summary>
        /// <para>The timestamp when the root task starts. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1651737301000</para>
        /// </summary>
        [NameInMap("StartTimeQuery")]
        [Validation(Required=false)]
        public long? StartTimeQuery { get; set; }

        /// <summary>
        /// <para>The ID of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d7b2acf8d362742123e4a84e1bf8****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLIENT_PROBLEM_CHECK</b>: a task of the Security Center agent</description></item>
        /// <item><description><b>CLIENT_DEV_OPS</b>: an O\&amp;M task of Cloud Assistant</description></item>
        /// <item><description><b>ASSET_SECURITY_CHECK</b>: a task of asset information collection</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify at least one of the <b>TaskType</b> and <b>RootTaskId</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CLIENT_PROBLEM_CHECK</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
