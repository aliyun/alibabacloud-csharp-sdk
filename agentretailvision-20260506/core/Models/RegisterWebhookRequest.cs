// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRetailVision20260506.Models
{
    public class RegisterWebhookRequest : TeaModel {
        /// <summary>
        /// <para>The key used for callback signature verification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>your_secret_key</para>
        /// </summary>
        [NameInMap("CallbackSecret")]
        [Validation(Required=false)]
        public string CallbackSecret { get; set; }

        /// <summary>
        /// <para>The default callback URL. A public HTTPS URL is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/callback">https://example.com/callback</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

    }

}
