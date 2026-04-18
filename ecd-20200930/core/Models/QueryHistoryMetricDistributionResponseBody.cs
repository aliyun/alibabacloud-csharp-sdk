// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class QueryHistoryMetricDistributionResponseBody : TeaModel {
        [NameInMap("DistributionList")]
        [Validation(Required=false)]
        public List<QueryHistoryMetricDistributionResponseBodyDistributionList> DistributionList { get; set; }
        public class QueryHistoryMetricDistributionResponseBodyDistributionList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2F2BF549-CBD9-1FED-9ABB-086B62D7B293</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Max")]
            [Validation(Required=false)]
            public float? Max { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Min")]
            [Validation(Required=false)]
            public float? Min { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2F2BF549-CBD9-1FED-9ABB-086B62D7B293</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>94</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
