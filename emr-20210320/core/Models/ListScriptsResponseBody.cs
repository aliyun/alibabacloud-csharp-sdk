// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListScriptsResponseBody : TeaModel {
        /// <summary>
        /// 本次请求所返回的最大记录条数。
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 返回读取到的数据位置，空代表数据已经读取完毕。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The scripts.
        /// </summary>
        [NameInMap("Scripts")]
        [Validation(Required=false)]
        public List<ListScriptsResponseBodyScripts> Scripts { get; set; }
        public class ListScriptsResponseBodyScripts : TeaModel {
            /// <summary>
            /// The name of the API operation.
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The time when the system finishes the running of the script. This parameter is returned only if the ScriptType parameter is set to NORMAL.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The policy that is used to handle execution failures of the script. Valid values:
            /// 
            /// *   FAILED_CONTINUE
            /// *   FAILED_BLOCK
            /// </summary>
            [NameInMap("ExecutionFailStrategy")]
            [Validation(Required=false)]
            public string ExecutionFailStrategy { get; set; }

            /// <summary>
            /// The time based on which the system runs the script. Valid values:
            /// 
            /// *   BEFORE_INSTALL
            /// *   AFTER_STARTED
            /// </summary>
            [NameInMap("ExecutionMoment")]
            [Validation(Required=false)]
            public string ExecutionMoment { get; set; }

            /// <summary>
            /// The status of the script. This parameter is returned only if the `ScriptType` parameter is set to `NORMAL`. Valid values:
            /// 
            /// *   SCRIPT_COMPLETED
            /// *   SCRIPT_SUBMISSION_FAILED
            /// *   SCRIPT_RUNNING
            /// </summary>
            [NameInMap("ExecutionState")]
            [Validation(Required=false)]
            public string ExecutionState { get; set; }

            /// <summary>
            /// The time when the script was last modified.
            /// </summary>
            [NameInMap("LastUpdateTime")]
            [Validation(Required=false)]
            public long? LastUpdateTime { get; set; }

            /// <summary>
            /// The node selector.
            /// </summary>
            [NameInMap("NodeSelector")]
            [Validation(Required=false)]
            public NodeSelector NodeSelector { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The runtime parameters of the script.
            /// </summary>
            [NameInMap("ScriptArgs")]
            [Validation(Required=false)]
            public string ScriptArgs { get; set; }

            /// <summary>
            /// The script ID.
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// The name of the script.
            /// </summary>
            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// The path in which the script is stored.
            /// </summary>
            [NameInMap("ScriptPath")]
            [Validation(Required=false)]
            public string ScriptPath { get; set; }

            /// <summary>
            /// The time when the system starts to run the script. This parameter is returned only if the ScriptType parameter is set to NORMAL.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// 本次请求条件下的数据总量。
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
