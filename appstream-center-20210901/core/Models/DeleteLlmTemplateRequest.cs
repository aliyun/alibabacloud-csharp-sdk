// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class DeleteLlmTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the model template.</para>
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
