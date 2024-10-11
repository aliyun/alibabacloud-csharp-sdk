// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ModifyFlowControlTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. The value is unique for each request. This facilitates troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F81A922-6C81-46D6-B78C-CC35E16B1691</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ModifyFlowControlTaskResponseBodyResult Result { get; set; }
        public class ModifyFlowControlTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1661506482</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-07T02:24:26.000Z</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the task was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-11T09:47:43.000Z</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The metadata.</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public ModifyFlowControlTaskResponseBodyResultMeta Meta { get; set; }
            public class ModifyFlowControlTaskResponseBodyResultMeta : TeaModel {
                /// <summary>
                /// <para>The description of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tst</para>
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
                /// <para>The type of the metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FlowControlTask</para>
                /// </summary>
                [NameInMap("metaType")]
                [Validation(Required=false)]
                public string MetaType { get; set; }

                /// <summary>
                /// <para>The IDs of scenes.</para>
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
                public List<ModifyFlowControlTaskResponseBodyResultMetaSelectionParams> SelectionParams { get; set; }
                public class ModifyFlowControlTaskResponseBodyResultMetaSelectionParams : TeaModel {
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
                    /// <para>The number of filtering conditions for the item selection rule.</para>
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
                /// <para>The settings for item exposure.</para>
                /// </summary>
                [NameInMap("target")]
                [Validation(Required=false)]
                public ModifyFlowControlTaskResponseBodyResultMetaTarget Target { get; set; }
                public class ModifyFlowControlTaskResponseBodyResultMetaTarget : TeaModel {
                    /// <summary>
                    /// <para>The type of the exposure.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>EXPOSE_PERCENT</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The number of exposures.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Active user test</para>
                /// </summary>
                [NameInMap("taskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

            }

            /// <summary>
            /// <para>The state of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DRAFT</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
