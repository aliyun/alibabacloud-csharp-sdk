// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class InitiatePptCreationV2Request : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("ExternalUserId")]
        [Validation(Required=false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsMobile")]
        [Validation(Required=false)]
        public bool? IsMobile { get; set; }

        [NameInMap("Outline")]
        [Validation(Required=false)]
        public string Outline { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PptTemplateId")]
        [Validation(Required=false)]
        public int? PptTemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PptTemplateType")]
        [Validation(Required=false)]
        public int? PptTemplateType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProcessType")]
        [Validation(Required=false)]
        public int? ProcessType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8a7dfece-f204-4380-a7d0-a13d37de3924</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>llm-2setzb9x4ewsd</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
