// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class MassPushV2Request : TeaModel {
        /// <summary>
        /// <para>The AppKey information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23267***</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>An idempotent parameter used to prevent duplicate pushes caused by API call retries on the client side. If the same IdempotentToken is used for calls within 15 minutes, only one push is performed, and subsequent calls return the result of the first successful push.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The parameter format is a standard 36-character UUID (8-4-4-4-12). Each valid character is a hexadecimal digit in the range 0-9 or a-f, case-insensitive.</description></item>
        /// <item><description>This parameter only prevents duplicate pushes caused by retries. It cannot prevent duplicate pushes caused by concurrent calls.</description></item>
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
        /// <para>The batch push tasks.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PushTasks")]
        [Validation(Required=false)]
        public List<PushTask> PushTasks { get; set; }

    }

}
