// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListScriptsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of records returned in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The position of the data read.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dd6b1b2a-5837-5237-abe4-ff0c89568982</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of scripts.</para>
        /// </summary>
        [NameInMap("Scripts")]
        [Validation(Required=false)]
        public List<ListScriptsResponseBodyScripts> Scripts { get; set; }
        public class ListScriptsResponseBodyScripts : TeaModel {
            /// <summary>
            /// <para>API name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ListScripts</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>End execution time. This value is returned only when <c>ScriptType</c> is <c>NORMAL</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639715635819</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>Execution failure strategy. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>FAILED_CONTINUE: Continue after failure.</description></item>
            /// <item><description>FAILED_BLOCK: Block after failure.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FAILED_CONTINUE</para>
            /// </summary>
            [NameInMap("ExecutionFailStrategy")]
            [Validation(Required=false)]
            public string ExecutionFailStrategy { get; set; }

            /// <summary>
            /// <para>Execution timing. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>BEFORE_INSTALL: Before application installation.</description></item>
            /// <item><description>AFTER_STARTED: After application startup.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BEFORE_INSTALL</para>
            /// </summary>
            [NameInMap("ExecutionMoment")]
            [Validation(Required=false)]
            public string ExecutionMoment { get; set; }

            /// <summary>
            /// <para>Script execution state. This value is returned only when <c>ScriptType</c> is <c>NORMAL</c>. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>SCRIPT_COMPLETED: Script executed successfully.</description></item>
            /// <item><description>SCRIPT_SUBMISSION_FAILED: Script execution failed.</description></item>
            /// <item><description>SCRIPT_RUNNING: Script is running.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SCRIPT_COMPLETED</para>
            /// </summary>
            [NameInMap("ExecutionState")]
            [Validation(Required=false)]
            public string ExecutionState { get; set; }

            /// <summary>
            /// <para>Time of the last update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639714634819</para>
            /// </summary>
            [NameInMap("LastUpdateTime")]
            [Validation(Required=false)]
            public long? LastUpdateTime { get; set; }

            /// <summary>
            /// <para>Node selector.</para>
            /// </summary>
            [NameInMap("NodeSelector")]
            [Validation(Required=false)]
            public NodeSelector NodeSelector { get; set; }

            /// <summary>
            /// <para>Region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Script execution parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>--mode=client -h -p</para>
            /// </summary>
            [NameInMap("ScriptArgs")]
            [Validation(Required=false)]
            public string ScriptArgs { get; set; }

            /// <summary>
            /// <para>Script ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cs-bf25219d103043a0820613e32781****</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>Script name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>check_env</para>
            /// </summary>
            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <para>Script path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket1/check_evn.sh</para>
            /// </summary>
            [NameInMap("ScriptPath")]
            [Validation(Required=false)]
            public string ScriptPath { get; set; }

            /// <summary>
            /// <para>Start execution time. This value is returned only when <c>ScriptType</c> is <c>NORMAL</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639714634000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The total amount of data under the conditions of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
