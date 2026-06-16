// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The request body for the template update.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateTemplateInput Body { get; set; }

        /// <summary>
        /// <para>A unique client token to ensure request idempotency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clientToken</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
