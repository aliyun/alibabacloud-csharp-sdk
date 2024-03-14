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

        [NameInMap("Scripts")]
        [Validation(Required=false)]
        public List<ListScriptsResponseBodyScripts> Scripts { get; set; }
        public class ListScriptsResponseBodyScripts : TeaModel {
            /// <summary>
            /// API名称。
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// 结束执行时间。
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// 执行失败策略。
            /// </summary>
            [NameInMap("ExecutionFailStrategy")]
            [Validation(Required=false)]
            public string ExecutionFailStrategy { get; set; }

            /// <summary>
            /// 执行时机。
            /// </summary>
            [NameInMap("ExecutionMoment")]
            [Validation(Required=false)]
            public string ExecutionMoment { get; set; }

            [NameInMap("ExecutionState")]
            [Validation(Required=false)]
            public string ExecutionState { get; set; }

            /// <summary>
            /// 最近一次编辑时间。
            /// </summary>
            [NameInMap("LastUpdateTime")]
            [Validation(Required=false)]
            public long? LastUpdateTime { get; set; }

            /// <summary>
            /// 节点选择器。
            /// </summary>
            [NameInMap("NodeSelector")]
            [Validation(Required=false)]
            public NodeSelector NodeSelector { get; set; }

            /// <summary>
            /// 区域ID。
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// 集群脚本执行参数。
            /// </summary>
            [NameInMap("ScriptArgs")]
            [Validation(Required=false)]
            public string ScriptArgs { get; set; }

            /// <summary>
            /// 脚本ID。
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// 集群脚本名称。
            /// </summary>
            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// 集群脚本路径。
            /// </summary>
            [NameInMap("ScriptPath")]
            [Validation(Required=false)]
            public string ScriptPath { get; set; }

            /// <summary>
            /// 开始执行时间。
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
