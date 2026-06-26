// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class MoMValues : TeaModel {
        /// <summary>
        /// <para>The current value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("currentValue")]
        [Validation(Required=false)]
        public long? CurrentValue { get; set; }

        /// <summary>
        /// <para>The value of the previous day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("lastDayValue")]
        [Validation(Required=false)]
        public long? LastDayValue { get; set; }

        /// <summary>
        /// <para>The value of the previous month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("lastMonthValue")]
        [Validation(Required=false)]
        public long? LastMonthValue { get; set; }

    }

}
