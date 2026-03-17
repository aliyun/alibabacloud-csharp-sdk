// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class ModelUsage : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>951</para>
        /// </summary>
        [NameInMap("inputTokens")]
        [Validation(Required=false)]
        public long? InputTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("outputTokens")]
        [Validation(Required=false)]
        public long? OutputTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>964</para>
        /// </summary>
        [NameInMap("totalTokens")]
        [Validation(Required=false)]
        public long? TotalTokens { get; set; }

    }

}
