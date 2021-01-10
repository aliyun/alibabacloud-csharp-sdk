// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Logiccomposer20181212.Models
{
    public class ListInvocationLogsResponseBody : TeaModel {
        /// <summary>
        /// 总页数
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

        /// <summary>
        /// 请求 ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 日志列表
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<ListInvocationLogsResponseBodyLogs> Logs { get; set; }
        public class ListInvocationLogsResponseBodyLogs : TeaModel {
            /// <summary>
            /// 执行状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 执行完成时间
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// 开始执行时间
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// 执行唯一标识符
            /// </summary>
            [NameInMap("InvocationId")]
            [Validation(Required=false)]
            public string InvocationId { get; set; }

            /// <summary>
            /// 返回码
            /// </summary>
            [NameInMap("ReturnCode")]
            [Validation(Required=false)]
            public string ReturnCode { get; set; }

            /// <summary>
            /// 错误信息
            /// </summary>
            [NameInMap("InvocationError")]
            [Validation(Required=false)]
            public ListInvocationLogsResponseBodyLogsInvocationError InvocationError { get; set; }
            public class ListInvocationLogsResponseBodyLogsInvocationError : TeaModel {
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }
            };

            /// <summary>
            /// 工作流详情
            /// </summary>
            [NameInMap("Workflow")]
            [Validation(Required=false)]
            public ListInvocationLogsResponseBodyLogsWorkflow Workflow { get; set; }
            public class ListInvocationLogsResponseBodyLogsWorkflow : TeaModel {
                [NameInMap("Definition")]
                [Validation(Required=false)]
                public string Definition { get; set; }
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }
            };

            /// <summary>
            /// 本次执行的标签
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListInvocationLogsResponseBodyLogsTags> Tags { get; set; }
            public class ListInvocationLogsResponseBodyLogsTags : TeaModel {
                /// <summary>
                /// 标签名
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// 标签值
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// 总数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
