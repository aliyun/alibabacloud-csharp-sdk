// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateMemoryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("longTtl")]
        [Validation(Required=false)]
        public int? LongTtl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("shortTtl")]
        [Validation(Required=false)]
        public int? ShortTtl { get; set; }

        [NameInMap("strategy")]
        [Validation(Required=false)]
        public List<string> Strategy { get; set; }

    }

}
