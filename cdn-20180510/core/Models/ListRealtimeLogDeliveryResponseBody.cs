// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ListRealtimeLogDeliveryResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListRealtimeLogDeliveryResponseBodyContent Content { get; set; }
        public class ListRealtimeLogDeliveryResponseBodyContent : TeaModel {
            [NameInMap("RealtimeLogDeliveryInfo")]
            [Validation(Required=false)]
            public List<ListRealtimeLogDeliveryResponseBodyContentRealtimeLogDeliveryInfo> RealtimeLogDeliveryInfo { get; set; }
            public class ListRealtimeLogDeliveryResponseBodyContentRealtimeLogDeliveryInfo : TeaModel {
                [NameInMap("DmId")]
                [Validation(Required=false)]
                public int? DmId { get; set; }

                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("Logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

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
