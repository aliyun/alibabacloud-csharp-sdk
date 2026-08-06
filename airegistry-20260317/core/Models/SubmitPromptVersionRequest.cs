// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class SubmitPromptVersionRequest : TeaModel {
        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the prompt.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customer-service-qa</para>
        /// </summary>
        [NameInMap("PromptKey")]
        [Validation(Required=false)]
        public string PromptKey { get; set; }

        /// <summary>
        /// <para>The version number to publish. If not specified, the current draft version is published by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.1</para>
        /// </summary>
        [NameInMap("PromptVersion")]
        [Validation(Required=false)]
        public string PromptVersion { get; set; }

    }

}
