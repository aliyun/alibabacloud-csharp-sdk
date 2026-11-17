// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateKnowledgeBaseRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token for the creation request. This parameter is optional. It accepts up to 64 characters and must contain at least one non-whitespace character. Use the same value when the same caller retries the same creation request in the same region. Reusing a token with different request content returns a conflict. If you omit the token, repeated requests may create multiple knowledge bases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-create-sales-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the knowledge base. This parameter is optional. The maximum length is 1024 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sales metrics and business policies</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base. This parameter cannot be empty. The maximum length is 128 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sales knowledge base</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of the knowledge base. PERSONAL: personal knowledge base. ENTERPRISE: enterprise knowledge base. If this parameter is omitted, the default value is PERSONAL. Creating an enterprise knowledge base requires the corresponding enterprise knowledge base capabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PERSONAL</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
