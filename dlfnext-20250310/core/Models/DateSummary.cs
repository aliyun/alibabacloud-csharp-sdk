// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class DateSummary : TeaModel {
        [NameInMap("date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// <para>Metric value at corresponding date</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public long? Value { get; set; }

    }

}
