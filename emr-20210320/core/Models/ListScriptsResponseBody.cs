// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListScriptsResponseBody : TeaModel {
        /// <summary>
        /// <para>本次请求所返回的最大记录条数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>返回读取到的数据位置，空代表数据已经读取完毕。</para>
        /// 
        /// <b>Example:</b>
        /// <para>dd6b1b2a-5837-5237-abe4-ff0c89568982</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scripts.</para>
        /// </summary>
        [NameInMap("Scripts")]
        [Validation(Required=false)]
        public List<ListScriptsResponseBodyScripts> Scripts { get; set; }
        public class ListScriptsResponseBodyScripts : TeaModel {
            /// <summary>
            /// <para>The name of the API operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ListScripts</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The time when the system finishes the running of the script. This parameter is returned only if the ScriptType parameter is set to NORMAL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639715635819</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The policy that is used to handle execution failures of the script. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FAILED_CONTINUE</description></item>
            /// <item><description>FAILED_BLOCK</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FAILED_CONTINUE</para>
            /// </summary>
            [NameInMap("ExecutionFailStrategy")]
            [Validation(Required=false)]
            public string ExecutionFailStrategy { get; set; }

            /// <summary>
            /// <para>The time based on which the system runs the script. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BEFORE_INSTALL</description></item>
            /// <item><description>AFTER_STARTED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BEFORE_INSTALL</para>
            /// </summary>
            [NameInMap("ExecutionMoment")]
            [Validation(Required=false)]
            public string ExecutionMoment { get; set; }

            /// <summary>
            /// <para>The status of the script. This parameter is returned only if the <c>ScriptType</c> parameter is set to <c>NORMAL</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SCRIPT_COMPLETED</description></item>
            /// <item><description>SCRIPT_SUBMISSION_FAILED</description></item>
            /// <item><description>SCRIPT_RUNNING</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SCRIPT_COMPLETED</para>
            /// </summary>
            [NameInMap("ExecutionState")]
            [Validation(Required=false)]
            public string ExecutionState { get; set; }

            /// <summary>
            /// <para>The time when the script was last modified.</para>
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
            /// <para>The name of the script.</para>
            /// 
            /// <b>Example:</b>
            /// <para>check_env</para>
            /// </summary>
            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <para>The path in which the script is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket1/check_evn.sh</para>
            /// </summary>
            [NameInMap("ScriptPath")]
            [Validation(Required=false)]
            public string ScriptPath { get; set; }

            /// <summary>
            /// <para>The time when the system starts to run the script. This parameter is returned only if the ScriptType parameter is set to NORMAL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639714634000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>本次请求条件下的数据总量。</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
