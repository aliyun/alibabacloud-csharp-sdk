// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetHotspotCompareResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPI.ServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetHotspotCompareResponseBodyData Data { get; set; }
        public class GetHotspotCompareResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The differential flame graph data.</para>
            /// </summary>
            [NameInMap("flame")]
            [Validation(Required=false)]
            public GetHotspotCompareResponseBodyDataFlame Flame { get; set; }
            public class GetHotspotCompareResponseBodyDataFlame : TeaModel {
                /// <summary>
                /// <para>The list of field names.</para>
                /// </summary>
                [NameInMap("columns")]
                [Validation(Required=false)]
                public List<string> Columns { get; set; }

                /// <summary>
                /// <para>The list of flame graph data.</para>
                /// </summary>
                [NameInMap("values")]
                [Validation(Required=false)]
                public List<List<string>> Values { get; set; }

            }

            /// <summary>
            /// <para>The hot spot time series 1.</para>
            /// </summary>
            [NameInMap("series_instance1")]
            [Validation(Required=false)]
            public GetHotspotCompareResponseBodyDataSeriesInstance1 SeriesInstance1 { get; set; }
            public class GetHotspotCompareResponseBodyDataSeriesInstance1 : TeaModel {
                /// <summary>
                /// <para>The list of field names.</para>
                /// </summary>
                [NameInMap("columns")]
                [Validation(Required=false)]
                public List<string> Columns { get; set; }

                /// <summary>
                /// <para>The list of hot spot time series data.</para>
                /// </summary>
                [NameInMap("values")]
                [Validation(Required=false)]
                public List<List<string>> Values { get; set; }

            }

            /// <summary>
            /// <para>The hot spot time series 2.</para>
            /// </summary>
            [NameInMap("series_instance2")]
            [Validation(Required=false)]
            public GetHotspotCompareResponseBodyDataSeriesInstance2 SeriesInstance2 { get; set; }
            public class GetHotspotCompareResponseBodyDataSeriesInstance2 : TeaModel {
                /// <summary>
                /// <para>The list of field names.</para>
                /// </summary>
                [NameInMap("columns")]
                [Validation(Required=false)]
                public List<string> Columns { get; set; }

                /// <summary>
                /// <para>The list of hot spot time series data.</para>
                /// </summary>
                [NameInMap("values")]
                [Validation(Required=false)]
                public List<List<string>> Values { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
