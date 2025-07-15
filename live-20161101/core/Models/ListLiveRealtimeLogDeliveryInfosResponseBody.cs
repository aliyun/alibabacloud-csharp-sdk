// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListLiveRealtimeLogDeliveryInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the configuration of real-time log delivery.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListLiveRealtimeLogDeliveryInfosResponseBodyContent Content { get; set; }
        public class ListLiveRealtimeLogDeliveryInfosResponseBodyContent : TeaModel {
            [NameInMap("RealtimeLogDeliveryInfos")]
            [Validation(Required=false)]
            public List<ListLiveRealtimeLogDeliveryInfosResponseBodyContentRealtimeLogDeliveryInfos> RealtimeLogDeliveryInfos { get; set; }
            public class ListLiveRealtimeLogDeliveryInfosResponseBodyContentRealtimeLogDeliveryInfos : TeaModel {
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

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95D5B69F-8AEC-419B-8F3A-612B35032B0D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
