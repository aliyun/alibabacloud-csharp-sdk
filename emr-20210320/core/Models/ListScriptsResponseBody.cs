// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListScriptsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned in the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dd6b1b2a-5837-5237-abe4-ff0c89568982</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of scripts.</para>
        /// </summary>
        [NameInMap("Scripts")]
        [Validation(Required=false)]
        public List<ListScriptsResponseBodyScripts> Scripts { get; set; }
        public class ListScriptsResponseBodyScripts : TeaModel {
            /// <summary>
            /// <para>The name of the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ListScripts</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The time when the execution ended. This parameter is returned only when ScriptType is set to NORMAL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639715635819</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The policy used to handle an execution failure. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>FAILED_CONTINUE: Continue the execution.</para>
            /// </description></item>
            /// <item><description><para>FAILED_BLOCK: Block the execution.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FAILED_CONTINUE</para>
            /// </summary>
            [NameInMap("ExecutionFailStrategy")]
            [Validation(Required=false)]
            public string ExecutionFailStrategy { get; set; }

            /// <summary>
            /// <para>The time to execute the script. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>BEFORE_INSTALL: before application installation.</para>
            /// </description></item>
            /// <item><description><para>AFTER_STARTED: after application startup.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BEFORE_INSTALL</para>
            /// </summary>
            [NameInMap("ExecutionMoment")]
            [Validation(Required=false)]
            public string ExecutionMoment { get; set; }

            /// <summary>
            /// <para>The execution status of the script. This parameter is returned only when <c>ScriptType</c> is set to <c>NORMAL</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>SCRIPT_COMPLETED: The script is successfully executed.</para>
            /// </description></item>
            /// <item><description><para>SCRIPT_SUBMISSION_FAILED: The script fails to be executed.</para>
            /// </description></item>
            /// <item><description><para>SCRIPT_RUNNING: The script is being executed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SCRIPT_COMPLETED</para>
            /// </summary>
            [NameInMap("ExecutionState")]
            [Validation(Required=false)]
            public string ExecutionState { get; set; }

            /// <summary>
            /// <para>The time when the script was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639714634819</para>
            /// </summary>
            [NameInMap("LastUpdateTime")]
            [Validation(Required=false)]
            public long? LastUpdateTime { get; set; }

            /// <summary>
            /// <para>The node selector.</para>
            /// </summary>
            [NameInMap("NodeSelector")]
            [Validation(Required=false)]
            public NodeSelector NodeSelector { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The runtime parameters of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>--mode=client -h -p</para>
            /// </summary>
            [NameInMap("ScriptArgs")]
            [Validation(Required=false)]
            public string ScriptArgs { get; set; }

            /// <summary>
            /// <para>The script ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cs-bf25219d103043a0820613e32781****</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>The script name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>check_env</para>
            /// </summary>
            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <para>The script path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket1/check_evn.sh</para>
            /// </summary>
            [NameInMap("ScriptPath")]
            [Validation(Required=false)]
            public string ScriptPath { get; set; }

            /// <summary>
            /// <para>The time when the execution started. This parameter is returned only when ScriptType is set to NORMAL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639714634000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries that meet the request conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
