// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class PushV2ShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The AppKey information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****530646</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>An idempotence parameter that prevents duplicate push notifications caused by retries from the API caller. If you use the same IdempotentToken within 15 minutes, only one push notification is sent, and subsequent calls return the result of the first successful push.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The parameter format is a standard 36-character UUID (8-4-4-4-12). Each valid character is a hexadecimal digit in the range 0-9 or a-f, case-insensitive.</description></item>
        /// <item><description>This parameter only prevents duplicate push notifications caused by retries. It cannot prevent duplicate push notifications caused by concurrent calls.</description></item>
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
        /// <para>The push task.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PushTask")]
        [Validation(Required=false)]
        public string PushTaskShrink { get; set; }

    }

}
