// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetInstanceSummaryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LockingCount")]
        [Validation(Required=false)]
        public int? LockingCount { get; set; }

        [NameInMap("RegionalSummary")]
        [Validation(Required=false)]
        public List<GetInstanceSummaryResponseBodyRegionalSummary> RegionalSummary { get; set; }
        public class GetInstanceSummaryResponseBodyRegionalSummary : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LockingCount")]
            [Validation(Required=false)]
            public int? LockingCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("RunningCount")]
            [Validation(Required=false)]
            public int? RunningCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1556DCB0-043A-4444-8BD9-CF4A68E7EE64</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("RunningCount")]
        [Validation(Required=false)]
        public int? RunningCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
