// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRetailVision20260506.Models
{
    public class RegisterWebhookRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>your_secret_key</para>
        /// </summary>
        [NameInMap("CallbackSecret")]
        [Validation(Required=false)]
        public string CallbackSecret { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://example.com/callback">https://example.com/callback</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

    }

}
