// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListAbnormalyEventsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListAbnormalyEventsResponseBodyData> Data { get; set; }
        public class ListAbnormalyEventsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1725801090000</para>
            /// </summary>
            [NameInMap("created_at")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("diag_status")]
            [Validation(Required=false)]
            public int? DiagStatus { get; set; }

            [NameInMap("end_at")]
            [Validation(Required=false)]
            public long? EndAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-wz9d00ut2ska3mlyhn6j</para>
            /// </summary>
            [NameInMap("instance")]
            [Validation(Required=false)]
            public string Instance { get; set; }

            [NameInMap("item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("opts")]
            [Validation(Required=false)]
            public List<ListAbnormalyEventsResponseBodyDataOpts> Opts { get; set; }
            public class ListAbnormalyEventsResponseBodyDataOpts : TeaModel {
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("result")]
                [Validation(Required=false)]
                public ListAbnormalyEventsResponseBodyDataOptsResult Result { get; set; }
                public class ListAbnormalyEventsResponseBodyDataOptsResult : TeaModel {
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("pod")]
            [Validation(Required=false)]
            public string Pod { get; set; }

            [NameInMap("raw_metrics")]
            [Validation(Required=false)]
            public ListAbnormalyEventsResponseBodyDataRawMetrics RawMetrics { get; set; }
            public class ListAbnormalyEventsResponseBodyDataRawMetrics : TeaModel {
                [NameInMap("end_time")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

                [NameInMap("metrics")]
                [Validation(Required=false)]
                public List<string> Metrics { get; set; }

                [NameInMap("start_time")]
                [Validation(Required=false)]
                public float? StartTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("region_id")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>saturation</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
