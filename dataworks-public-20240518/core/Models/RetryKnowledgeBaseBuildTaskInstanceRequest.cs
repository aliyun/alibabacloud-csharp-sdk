// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class RetryKnowledgeBaseBuildTaskInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency key for the retry operation. Keep the original value when you resend the same request, and use a new token when you initiate another retry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>retry-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the knowledge base.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abc</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The ID of the instance to be retried.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20001</para>
        /// </summary>
        [NameInMap("TaskInstanceId")]
        [Validation(Required=false)]
        public string TaskInstanceId { get; set; }

    }

}
