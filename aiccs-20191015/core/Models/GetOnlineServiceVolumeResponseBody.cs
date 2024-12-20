// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetOnlineServiceVolumeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOnlineServiceVolumeResponseBodyData Data { get; set; }
        public class GetOnlineServiceVolumeResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;tenant_id&quot;:&quot;905&quot;,&quot;online_40s_transfer_ready_cnt&quot;:109,&quot;minute_id&quot;:&quot;-1&quot;,&quot;wait_time_len&quot;:1215,&quot;pickup_rate&quot;:&quot;63.09%&quot;,&quot;thirty_seconds_to_pickUp&quot;:&quot;2560&quot;,&quot;date_id&quot;:&quot;-1&quot;,&quot;online_over_out_cnt&quot;:0,&quot;online_20s_transfer_ready_cnt&quot;:109,&quot;thirty_seconds_response_rate&quot;:&quot;63.09%&quot;,&quot;abandonment_rate&quot;:&quot;63.09%&quot;,&quot;service_time_len&quot;:68378,&quot;service_pickup&quot;:&quot;2560&quot;,&quot;hour_id&quot;:&quot;-1&quot;,&quot;online_10s_transfer_ready_cnt&quot;:109}</para>
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public string Rows { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
