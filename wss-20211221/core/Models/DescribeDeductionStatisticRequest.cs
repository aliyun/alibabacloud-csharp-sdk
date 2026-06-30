// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeDeductionStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The end time, specified as a Unix timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-06T02:14:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The list of instance IDs, specified as a JSON array.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The list of periods, formatted as a JSON array of <c>PeriodParam</c> objects.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Periods")]
        [Validation(Required=false)]
        public List<DescribeDeductionStatisticRequestPeriods> Periods { get; set; }
        public class DescribeDeductionStatisticRequestPeriods : TeaModel {
            /// <summary>
            /// <para>The base time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01</para>
            /// </summary>
            [NameInMap("BaseTime")]
            [Validation(Required=false)]
            public string BaseTime { get; set; }

            /// <summary>
            /// <para>The period unit. For valid values, see the <c>PeriodUnit</c> enumeration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Year</para>
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

        }

        /// <summary>
        /// <para>The list of resource types, specified as a JSON array.</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public List<string> ResourceTypes { get; set; }

        /// <summary>
        /// <para>The start time, specified as a Unix timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-03-20T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
