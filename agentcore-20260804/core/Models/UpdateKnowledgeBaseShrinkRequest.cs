// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateKnowledgeBaseShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Provide at least one field to be updated. Unprovided fields remain unchanged. You can pass an empty string for the description field to clear the description, or omit it to keep the description unchanged.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string BodyShrink { get; set; }

        /// <summary>
        /// <para>Optional. For retries on the same knowledge base with the same client token and identical update content, the accepted result is returned without further modifications. If the content differs, an IdempotencyConflict error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-update-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
