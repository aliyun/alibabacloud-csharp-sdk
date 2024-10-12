// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListAsyncTasksShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cd327c3d5d5e44159cc716e23bfa530e_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-03-18 02:00:00</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-02-19 07:28:11</para>
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public string CreateTimeStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MaterialDocumentUpload</para>
        /// </summary>
        [NameInMap("TaskCode")]
        [Validation(Required=false)]
        public string TaskCode { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public int? TaskStatus { get; set; }

        [NameInMap("TaskStatusList")]
        [Validation(Required=false)]
        public string TaskStatusListShrink { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("TaskTypeList")]
        [Validation(Required=false)]
        public string TaskTypeListShrink { get; set; }

    }

}
