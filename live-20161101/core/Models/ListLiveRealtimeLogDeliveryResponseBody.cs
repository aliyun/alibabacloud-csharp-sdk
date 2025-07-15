// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListLiveRealtimeLogDeliveryResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations of real-time log delivery.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListLiveRealtimeLogDeliveryResponseBodyContent Content { get; set; }
        public class ListLiveRealtimeLogDeliveryResponseBodyContent : TeaModel {
            [NameInMap("RealtimeLogDeliveryInfo")]
            [Validation(Required=false)]
            public List<ListLiveRealtimeLogDeliveryResponseBodyContentRealtimeLogDeliveryInfo> RealtimeLogDeliveryInfo { get; set; }
            public class ListLiveRealtimeLogDeliveryResponseBodyContentRealtimeLogDeliveryInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001010</para>
                /// </summary>
                [NameInMap("DmId")]
                [Validation(Required=false)]
                public int? DmId { get; set; }

                /// <summary>
                /// <para>The streaming domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The name of the Logstore to which log entries are delivered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>logstore_example</para>
                /// </summary>
                [NameInMap("Logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <para>The name of the Log Service project that is used for real-time log delivery.</para>
                /// 
                /// <b>Example:</b>
                /// <para>project_example</para>
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The ID of the region where the Log Service project is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The status of real-time log delivery. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>online</b>: enabled</description></item>
                /// <item><description><b>offline</b>: disabled</description></item>
                /// </list>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30559C03-86C9-4EEC-B840-0DC5F5A2189B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
