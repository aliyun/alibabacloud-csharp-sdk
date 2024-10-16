// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class CreatePromptTemplateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6e49109bfeb94a39bb268f4e483ccxxx</para>
        /// </summary>
        [NameInMap("promptTemplateId")]
        [Validation(Required=false)]
        public string PromptTemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FE9B6CBF-47E6-5D76-9C5D-B814DD5ABxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
