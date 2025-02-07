// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetHotspotTrackingResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SysomOpenAPI.ServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetHotspotTrackingResponseBodyData Data { get; set; }
        public class GetHotspotTrackingResponseBodyData : TeaModel {
            [NameInMap("flame")]
            [Validation(Required=false)]
            public GetHotspotTrackingResponseBodyDataFlame Flame { get; set; }
            public class GetHotspotTrackingResponseBodyDataFlame : TeaModel {
                [NameInMap("columns")]
                [Validation(Required=false)]
                public List<string> Columns { get; set; }

                [NameInMap("values")]
                [Validation(Required=false)]
                public List<List<string>> Values { get; set; }

            }

            [NameInMap("series")]
            [Validation(Required=false)]
            public GetHotspotTrackingResponseBodyDataSeries Series { get; set; }
            public class GetHotspotTrackingResponseBodyDataSeries : TeaModel {
                [NameInMap("columns")]
                [Validation(Required=false)]
                public List<string> Columns { get; set; }

                [NameInMap("values")]
                [Validation(Required=false)]
                public List<List<string>> Values { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
