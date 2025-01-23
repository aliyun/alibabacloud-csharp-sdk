// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class SubQuotaPreemptionConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("PreemptedPriorityUpperBound")]
        [Validation(Required=false)]
        public long? PreemptedPriorityUpperBound { get; set; }

        [NameInMap("PreemptedProducts")]
        [Validation(Required=false)]
        public List<string> PreemptedProducts { get; set; }

    }

}
