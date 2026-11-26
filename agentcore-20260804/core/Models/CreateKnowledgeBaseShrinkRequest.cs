// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateKnowledgeBaseShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The request parameters for creating a knowledge base.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string BodyShrink { get; set; }

        /// <summary>
        /// <para>The optional idempotency token for the creation request. If provided, it must be a non-blank string with a maximum length of 128 characters. Within the same workspace, the same token and the same request return the original result, while different requests return IdempotencyConflict. If not provided, each request is processed as a new request, and idempotency across request retries is not guaranteed. Creation with the same name is still subject to the name uniqueness constraint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-create-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
