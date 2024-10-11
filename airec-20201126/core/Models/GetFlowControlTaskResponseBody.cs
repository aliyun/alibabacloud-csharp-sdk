// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class GetFlowControlTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>829F38F6-E2D6-4109-90A6-888160BD16C2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetFlowControlTaskResponseBodyResult> Result { get; set; }
        public class GetFlowControlTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the task was created. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in Coordinated Universal Time (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-07T02:24:26.000Z</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the data source was last modified. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-04-23T06:08:48.000Z</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The metadata of the task.</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public GetFlowControlTaskResponseBodyResultMeta Meta { get; set; }
            public class GetFlowControlTaskResponseBodyResultMeta : TeaModel {
                /// <summary>
                /// <para>The task description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The end time. The value is a timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1656518399</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The metadata type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FlowControlTask</para>
                /// </summary>
                [NameInMap("metaType")]
                [Validation(Required=false)]
                public string MetaType { get; set; }

                /// <summary>
                /// <para>The scene IDs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1,2,3</para>
                /// </summary>
                [NameInMap("sceneIds")]
                [Validation(Required=false)]
                public string SceneIds { get; set; }

                /// <summary>
                /// <para>The parameters specified for the item selection rule.</para>
                /// </summary>
                [NameInMap("selectionParams")]
                [Validation(Required=false)]
                public List<GetFlowControlTaskResponseBodyResultMetaSelectionParams> SelectionParams { get; set; }
                public class GetFlowControlTaskResponseBodyResultMetaSelectionParams : TeaModel {
                    /// <summary>
                    /// <para>The type of the filtering condition for the item selection rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>QUERY_PUB_TIME</para>
                    /// </summary>
                    [NameInMap("selectType")]
                    [Validation(Required=false)]
                    public string SelectType { get; set; }

                    /// <summary>
                    /// <para>The value of the filtering condition for the item selection rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("selectValue")]
                    [Validation(Required=false)]
                    public string SelectValue { get; set; }

                    /// <summary>
                    /// <para>The operation on the filtering condition for the item selection rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OPERATOR_HIGHER</para>
                    /// </summary>
                    [NameInMap("selectionOperation")]
                    [Validation(Required=false)]
                    public string SelectionOperation { get; set; }

                }

                /// <summary>
                /// <para>The start time. The value is a timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1640739600</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The exposure settings.</para>
                /// </summary>
                [NameInMap("target")]
                [Validation(Required=false)]
                public GetFlowControlTaskResponseBodyResultMetaTarget Target { get; set; }
                public class GetFlowControlTaskResponseBodyResultMetaTarget : TeaModel {
                    /// <summary>
                    /// <para>EXPOSE_PERCENT: daily exposure percentage. EXPOSE_COUNT: total number of exposures.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>EXPOSE_PERCENT</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The exposure value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The task name.</para>
                /// </summary>
                [NameInMap("taskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

            }

            /// <summary>
            /// <para>The task state. Valid values: DRAFT, READY, RUNNING, ENDED, and AUTO_END. The value AUTO_END is not used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DRAFT</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1666854602398</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
