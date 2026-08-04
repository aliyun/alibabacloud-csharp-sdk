// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class BalancePoolSummaryDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>40.00</para>
        /// </summary>
        [NameInMap("allocated")]
        [Validation(Required=false)]
        public double? Allocated { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60.00</para>
        /// </summary>
        [NameInMap("available")]
        [Validation(Required=false)]
        public double? Available { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100.00</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public double? Total { get; set; }

    }

}
