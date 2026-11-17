// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class DisableOutputItemShareRequest : TeaModel {
        /// <summary>
        /// <para>The output item ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleOutputItemId</para>
        /// </summary>
        [NameInMap("outputItemId")]
        [Validation(Required=false)]
        public string OutputItemId { get; set; }

        /// <summary>
        /// <para>The name of the output item. This parameter must be used together with sessionId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Quarterly Review.pptx</para>
        /// </summary>
        [NameInMap("outputItemName")]
        [Validation(Required=false)]
        public string OutputItemName { get; set; }

        /// <summary>
        /// <para>The session ID used for exact filtering. The value must be 1 to 128 characters in length. It applies to common sessions, skill sessions, and the execution ID of task executions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSessionId</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
