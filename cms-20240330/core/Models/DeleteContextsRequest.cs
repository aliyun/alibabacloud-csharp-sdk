// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DeleteContextsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>mem_long_01,mem_long_02</para>
        /// </summary>
        [NameInMap("contextIds")]
        [Validation(Required=false)]
        public string ContextIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;userId&quot;:&quot;u-10001&quot;}</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

    }

}
