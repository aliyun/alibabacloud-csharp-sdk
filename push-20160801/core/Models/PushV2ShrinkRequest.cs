// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class PushV2ShrinkRequest : TeaModel {
        /// <summary>
        /// <para>AppKey value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****530646</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>An idempotency token to prevent duplicate pushes caused by client-side retries. If you call this API with the same IdempotentToken within 15 minutes, only one push is sent. Subsequent calls return the result of the first successful push.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Format the token as a standard 36-character UUID (8-4-4-4-12). Valid characters are hexadecimal digits 0–9 and a–f. Case-insensitive.</para>
        /// </description></item>
        /// <item><description><para>This parameter prevents duplicates only from retries. It does not prevent duplicates from concurrent calls.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c8016d13-6e76-****-9bda-769383d11787</para>
        /// </summary>
        [NameInMap("IdempotentToken")]
        [Validation(Required=false)]
        public string IdempotentToken { get; set; }

        /// <summary>
        /// <para>Push task definition.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PushTask")]
        [Validation(Required=false)]
        public string PushTaskShrink { get; set; }

    }

}
