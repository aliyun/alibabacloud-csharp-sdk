// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ModifyFlowControlTaskRequest : TeaModel {
        /// <summary>
        /// <para>The name of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The description of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The end time. The value is a timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1639519200</para>
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
        /// <para>The ID of the scene.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all,sy101</para>
        /// </summary>
        [NameInMap("sceneIds")]
        [Validation(Required=false)]
        public string SceneIds { get; set; }

        /// <summary>
        /// <para>The parameters specified for the item selection rule.</para>
        /// </summary>
        [NameInMap("selectionParams")]
        [Validation(Required=false)]
        public List<ModifyFlowControlTaskRequestSelectionParams> SelectionParams { get; set; }
        public class ModifyFlowControlTaskRequestSelectionParams : TeaModel {
            /// <summary>
            /// <para>The type of the filtering condition for the item selection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>invalidItem</para>
            /// </summary>
            [NameInMap("selectType")]
            [Validation(Required=false)]
            public string SelectType { get; set; }

            /// <summary>
            /// <para>The number of filtering conditions for the item selection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
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
        /// <para>1638460800</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The settings for item exposure.</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public ModifyFlowControlTaskRequestTarget Target { get; set; }
        public class ModifyFlowControlTaskRequestTarget : TeaModel {
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
            /// <para>50</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public long? Value { get; set; }

        }

    }

}
