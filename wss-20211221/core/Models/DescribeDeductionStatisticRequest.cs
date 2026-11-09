// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeDeductionStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query. UNIX timestamp, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1749176040000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The list of instance IDs in JSON array format.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The list of time periods in JSON array format. Each element is a <c>PeriodParam</c> object.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Periods")]
        [Validation(Required=false)]
        public List<DescribeDeductionStatisticRequestPeriods> Periods { get; set; }
        public class DescribeDeductionStatisticRequestPeriods : TeaModel {
            /// <summary>
            /// <para>The base time in the YYYY-MM-DD format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01</para>
            /// </summary>
            [NameInMap("BaseTime")]
            [Validation(Required=false)]
            public string BaseTime { get; set; }

            /// <summary>
            /// <para>The time period unit. For more information, see the <c>PeriodUnit</c> enumeration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Year</para>
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

        }

        /// <summary>
        /// <para>The list of resource types in JSON array format.</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public List<string> ResourceTypes { get; set; }

        /// <summary>
        /// <para>The start time of the query. UNIX timestamp, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1774022400000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
