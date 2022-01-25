// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetWorkFlowResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// 工作流的数据
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWorkFlowResponseBodyData Data { get; set; }
        public class GetWorkFlowResponseBodyData : TeaModel {
            [NameInMap("WorkFlowInfo")]
            [Validation(Required=false)]
            public GetWorkFlowResponseBodyDataWorkFlowInfo WorkFlowInfo { get; set; }
            public class GetWorkFlowResponseBodyDataWorkFlowInfo : TeaModel {
                /// <summary>
                /// 工作流描述
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// 工作流名称
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 工作流状态
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// 工作流时间表达式
                /// </summary>
                [NameInMap("TimeExpression")]
                [Validation(Required=false)]
                public string TimeExpression { get; set; }

                /// <summary>
                /// 工作流时间类型
                /// </summary>
                [NameInMap("TimeType")]
                [Validation(Required=false)]
                public string TimeType { get; set; }

                /// <summary>
                /// 工作流ID
                /// </summary>
                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public long? WorkflowId { get; set; }

            }
            [NameInMap("WorkFlowNodeInfo")]
            [Validation(Required=false)]
            public GetWorkFlowResponseBodyDataWorkFlowNodeInfo WorkFlowNodeInfo { get; set; }
            public class GetWorkFlowResponseBodyDataWorkFlowNodeInfo : TeaModel {
                /// <summary>
                /// 工作流边列表
                /// </summary>
                [NameInMap("Edges")]
                [Validation(Required=false)]
                public List<GetWorkFlowResponseBodyDataWorkFlowNodeInfoEdges> Edges { get; set; }
                public class GetWorkFlowResponseBodyDataWorkFlowNodeInfoEdges : TeaModel {
                    /// <summary>
                    /// 起始任务ID
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public long? Source { get; set; }

                    /// <summary>
                    /// 目的任务ID
                    /// </summary>
                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public long? Target { get; set; }

                }

                /// <summary>
                /// 工作流节点列表
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public List<GetWorkFlowResponseBodyDataWorkFlowNodeInfoNodes> Nodes { get; set; }
                public class GetWorkFlowResponseBodyDataWorkFlowNodeInfoNodes : TeaModel {
                    /// <summary>
                    /// 任务ID
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// 任务名称
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// 任务状态
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                }

            }
        };

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 会否成功
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
