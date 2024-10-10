// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDIJobMetricsResponseBody : TeaModel {
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDIJobMetricsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDIJobMetricsResponseBodyPagingInfo : TeaModel {
            [NameInMap("JobMetrics")]
            [Validation(Required=false)]
            public List<ListDIJobMetricsResponseBodyPagingInfoJobMetrics> JobMetrics { get; set; }
            public class ListDIJobMetricsResponseBodyPagingInfoJobMetrics : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>JobDelay</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("SeriesList")]
                [Validation(Required=false)]
                public List<ListDIJobMetricsResponseBodyPagingInfoJobMetricsSeriesList> SeriesList { get; set; }
                public class ListDIJobMetricsResponseBodyPagingInfoJobMetricsSeriesList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1716881141</para>
                    /// </summary>
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public long? Time { get; set; }

                    /// <summary>
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
        /// <b>Example:</b>
        /// <para>691CA452-D37A-4ED0-9441</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
