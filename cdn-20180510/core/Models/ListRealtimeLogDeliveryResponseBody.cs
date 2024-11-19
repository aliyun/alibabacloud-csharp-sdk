// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ListRealtimeLogDeliveryResponseBody : TeaModel {
        /// <summary>
        /// <para>The logging information.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListRealtimeLogDeliveryResponseBodyContent Content { get; set; }
        public class ListRealtimeLogDeliveryResponseBodyContent : TeaModel {
            [NameInMap("RealtimeLogDeliveryInfo")]
            [Validation(Required=false)]
            public List<ListRealtimeLogDeliveryResponseBodyContentRealtimeLogDeliveryInfo> RealtimeLogDeliveryInfo { get; set; }
            public class ListRealtimeLogDeliveryResponseBodyContentRealtimeLogDeliveryInfo : TeaModel {
                /// <summary>
                /// <para>The domain ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001010</para>
                /// </summary>
                [NameInMap("DmId")]
                [Validation(Required=false)]
                public int? DmId { get; set; }

                /// <summary>
                /// <para>The accelerated domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The name of the Logstore where log entries are stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <para>The name of the Log Service project that is used for real-time log delivery.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The ID of the region where the Log Service project is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-corp</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The status of real-time log delivery.</para>
                /// 
                /// <b>Example:</b>
                /// <para>online</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30559C03-86C9-4EEC-B840-0DC5F5A2189B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
