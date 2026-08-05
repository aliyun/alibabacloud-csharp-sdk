// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveInteractionMetricDataResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of data points.</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<DescribeLiveInteractionMetricDataResponseBodyNodes> Nodes { get; set; }
        public class DescribeLiveInteractionMetricDataResponseBodyNodes : TeaModel {
            /// <summary>
            /// <para>The timestamp of the data point, specified as a UNIX timestamp in milliseconds.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A01C98C5-25AE-124A-83FE-514DF5C5BE36</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The summarized data for the query time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("SummaryData")]
        [Validation(Required=false)]
        public string SummaryData { get; set; }

    }

}
