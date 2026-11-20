// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class QueryModelUsageInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The model usage summary corresponding to the selected business, statistical window, and model type. If no statistical results are available for <c>24h</c> or <c>1d</c> queries without specified start and end dates, each metric returns 0. If no statistical results are available for other windows or custom date ranges, no valid metric values are provided. In this case, do not treat it as zero usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ActiveModelCount&quot;:10,&quot;CallCount&quot;:13280,&quot;PointsConsumption&quot;:120}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryModelUsageInfoResponseBodyData Data { get; set; }
        public class QueryModelUsageInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of distinct models that have been called at least once within the query range. Unit: models. The value is deduplicated by model code. It may not be equal to <c>TotalCount</c> in the model usage list, because the latter may also include models that have not been called within the current query range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ActiveModelCount")]
            [Validation(Required=false)]
            public long? ActiveModelCount { get; set; }

            /// <summary>
            /// <para>The total number of model calls within the query range. Unit: calls. This includes both successful and failed calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13280</para>
            /// </summary>
            [NameInMap("CallCount")]
            [Validation(Required=false)]
            public long? CallCount { get; set; }

            /// <summary>
            /// <para>The actual points consumed within the query range. Unit: points. The returned value can be displayed directly without further conversion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("PointsConsumption")]
            [Validation(Required=false)]
            public double? PointsConsumption { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the current request, which is used to locate and troubleshoot request issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
