// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeDeductionStatisticRequest : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Periods")]
        [Validation(Required=false)]
        public List<DescribeDeductionStatisticRequestPeriods> Periods { get; set; }
        public class DescribeDeductionStatisticRequestPeriods : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-01</para>
            /// </summary>
            [NameInMap("BaseTime")]
            [Validation(Required=false)]
            public string BaseTime { get; set; }

            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

        }

        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public List<string> ResourceTypes { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
