// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListFlowControlTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6E427B10-30FC-1873-922F-FC176D3398D4</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListFlowControlTaskResponseBodyResult> Result { get; set; }
        public class ListFlowControlTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1661506482</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-08-06T06:14:01.000Z</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-08-06T06:14:01.000Z</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("meta")]
            [Validation(Required=false)]
            public ListFlowControlTaskResponseBodyResultMeta Meta { get; set; }
            public class ListFlowControlTaskResponseBodyResultMeta : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1621267200</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>metaType</para>
                /// </summary>
                [NameInMap("metaType")]
                [Validation(Required=false)]
                public string MetaType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1,2,3</para>
                /// </summary>
                [NameInMap("sceneIds")]
                [Validation(Required=false)]
                public string SceneIds { get; set; }

                [NameInMap("selectionParams")]
                [Validation(Required=false)]
                public List<ListFlowControlTaskResponseBodyResultMetaSelectionParams> SelectionParams { get; set; }
                public class ListFlowControlTaskResponseBodyResultMetaSelectionParams : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>selectType</para>
                    /// </summary>
                    [NameInMap("selectType")]
                    [Validation(Required=false)]
                    public string SelectType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>selectValue</para>
                    /// </summary>
                    [NameInMap("selectValue")]
                    [Validation(Required=false)]
                    public string SelectValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>selectionOperation</para>
                    /// </summary>
                    [NameInMap("selectionOperation")]
                    [Validation(Required=false)]
                    public string SelectionOperation { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1621267200</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("target")]
                [Validation(Required=false)]
                public ListFlowControlTaskResponseBodyResultMetaTarget Target { get; set; }
                public class ListFlowControlTaskResponseBodyResultMetaTarget : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>EXPOSE_PERCENT</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>testtaskname</para>
                /// </summary>
                [NameInMap("taskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DRAFT</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
