// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveInteractionMetricDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The node data.</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<DescribeLiveInteractionMetricDataResponseBodyNodes> Nodes { get; set; }
        public class DescribeLiveInteractionMetricDataResponseBodyNodes : TeaModel {
            /// <summary>
            /// <para>The time when the metric was queried. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1548670257000</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// <para>The value of the metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66.670000</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A01C98C5-25AE-124A-83FE-514DF5C5BE36</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The summary data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("SummaryData")]
        [Validation(Required=false)]
        public string SummaryData { get; set; }

    }

}
