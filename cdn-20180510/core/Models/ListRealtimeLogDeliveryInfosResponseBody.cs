// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ListRealtimeLogDeliveryInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about real-time log delivery.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListRealtimeLogDeliveryInfosResponseBodyContent Content { get; set; }
        public class ListRealtimeLogDeliveryInfosResponseBodyContent : TeaModel {
            [NameInMap("RealtimeLogDeliveryInfos")]
            [Validation(Required=false)]
            public List<ListRealtimeLogDeliveryInfosResponseBodyContentRealtimeLogDeliveryInfos> RealtimeLogDeliveryInfos { get; set; }
            public class ListRealtimeLogDeliveryInfosResponseBodyContentRealtimeLogDeliveryInfos : TeaModel {
                /// <summary>
                /// <para>The name of the Logstore that collects log data from Alibaba Cloud CDN in real time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LogstoreName</para>
                /// </summary>
                [NameInMap("Logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <para>The name of the Log Service project that is used for real-time log delivery.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ProjectName</para>
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The ID of the region where the Log Service project is deployed. For more information, see <a href="https://help.aliyun.com/document_detail/144883.html">Regions that support real-time log delivery</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ch-shanghai</para>
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
