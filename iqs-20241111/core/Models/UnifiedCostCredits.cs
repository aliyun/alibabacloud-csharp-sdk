// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class UnifiedCostCredits : TeaModel {
        /// <summary>
        /// <para>The basic search service metering.</para>
        /// </summary>
        [NameInMap("search")]
        [Validation(Required=false)]
        public SearchCredits Search { get; set; }

        /// <summary>
        /// <para>The value-added service metering.</para>
        /// </summary>
        [NameInMap("valueAdded")]
        [Validation(Required=false)]
        public ValueAddedCredits ValueAdded { get; set; }

    }

}
