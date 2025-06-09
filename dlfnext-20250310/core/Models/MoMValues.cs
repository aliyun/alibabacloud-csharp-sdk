// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class MoMValues : TeaModel {
        /// <summary>
        /// <para>total</para>
        /// </summary>
        [NameInMap("currentValue")]
        [Validation(Required=false)]
        public long? CurrentValue { get; set; }

        /// <summary>
        /// <para>daily addition</para>
        /// </summary>
        [NameInMap("lastDayValue")]
        [Validation(Required=false)]
        public long? LastDayValue { get; set; }

        /// <summary>
        /// <para>monthly addition</para>
        /// </summary>
        [NameInMap("lastMonthValue")]
        [Validation(Required=false)]
        public long? LastMonthValue { get; set; }

    }

}
