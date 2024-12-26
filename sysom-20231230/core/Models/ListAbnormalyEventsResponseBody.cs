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
            public float? CreatedAt { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

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

            [NameInMap("opts")]
            [Validation(Required=false)]
            public ListAbnormalyEventsResponseBodyDataOpts Opts { get; set; }
            public class ListAbnormalyEventsResponseBodyDataOpts : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>diagnose</para>
                /// </summary>
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;{\&quot;service_name\&quot;: \&quot;oomcheck\&quot;, \&quot;params\&quot;: {\&quot;auto_initial\&quot;: true, \&quot;instance\&quot;: \&quot;i-wz9d00ut2ska3mlyhn6i\&quot;, \&quot;region\&quot;: \&quot;cn-shenzhen\&quot;, \&quot;uuid\&quot;: \&quot;24576d0c-a19d-49dd-8a64-3867440fd7a6\&quot;, \&quot;is_history\&quot;: 1}}&quot;</para>
                /// </summary>
                [NameInMap("params")]
                [Validation(Required=false)]
                public string Params { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>realtime</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

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

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
