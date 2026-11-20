// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class DeleteLlmTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the model to be deleted. You can call <a href="~~ListLlmTemplates~~">ListLlmTemplates</a> to obtain the ID. Use the LlmTemplateId of the specific model. Do not use the model group ID or provider template ID.</para>
        /// <para>The model must exist and be manageable by the current account. If the model has been deleted or does not exist, LlmTemplate.NotFound is returned. For instructions on how to handle default models, see the operation description.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llmt-xxxx</para>
        /// </summary>
        [NameInMap("LlmTemplateId")]
        [Validation(Required=false)]
        public string LlmTemplateId { get; set; }

    }

}
