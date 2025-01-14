// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDIJobMetricsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDIJobMetricsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDIJobMetricsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The metrics returned.</para>
            /// </summary>
            [NameInMap("JobMetrics")]
            [Validation(Required=false)]
            public List<ListDIJobMetricsResponseBodyPagingInfoJobMetrics> JobMetrics { get; set; }
            public class ListDIJobMetricsResponseBodyPagingInfoJobMetrics : TeaModel {
                /// <summary>
                /// <para>The name of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>JobDelay</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The metric data.</para>
                /// </summary>
                [NameInMap("SeriesList")]
                [Validation(Required=false)]
                public List<ListDIJobMetricsResponseBodyPagingInfoJobMetricsSeriesList> SeriesList { get; set; }
                public class ListDIJobMetricsResponseBodyPagingInfoJobMetricsSeriesList : TeaModel {
                    /// <summary>
                    /// <para>The point in time at which data is sampled based on the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1716881141</para>
                    /// </summary>
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public long? Time { get; set; }

                    /// <summary>
                    /// <para>The sample value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public double? Value { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>691CA452-D37A-4ED0-9441</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
