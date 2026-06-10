// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetHotspotTrackingResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPI.ServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetHotspotTrackingResponseBodyData Data { get; set; }
        public class GetHotspotTrackingResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Flame graph data</para>
            /// </summary>
            [NameInMap("flame")]
            [Validation(Required=false)]
            public GetHotspotTrackingResponseBodyDataFlame Flame { get; set; }
            public class GetHotspotTrackingResponseBodyDataFlame : TeaModel {
                /// <summary>
                /// <para>List of column names</para>
                /// </summary>
                [NameInMap("columns")]
                [Validation(Required=false)]
                public List<string> Columns { get; set; }

                /// <summary>
                /// <para>List of flame graph data</para>
                /// </summary>
                [NameInMap("values")]
                [Validation(Required=false)]
                public List<List<string>> Values { get; set; }

            }

            /// <summary>
            /// <para>Data list</para>
            /// </summary>
            [NameInMap("series")]
            [Validation(Required=false)]
            public GetHotspotTrackingResponseBodyDataSeries Series { get; set; }
            public class GetHotspotTrackingResponseBodyDataSeries : TeaModel {
                /// <summary>
                /// <para>List of column names</para>
                /// </summary>
                [NameInMap("columns")]
                [Validation(Required=false)]
                public List<string> Columns { get; set; }

                /// <summary>
                /// <para>List of hot spot metric data</para>
                /// </summary>
                [NameInMap("values")]
                [Validation(Required=false)]
                public List<List<string>> Values { get; set; }

            }

        }

        /// <summary>
        /// <para>Return message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
