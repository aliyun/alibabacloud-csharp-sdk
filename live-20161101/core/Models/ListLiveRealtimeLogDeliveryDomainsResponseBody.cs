// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListLiveRealtimeLogDeliveryDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain names.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListLiveRealtimeLogDeliveryDomainsResponseBodyContent Content { get; set; }
        public class ListLiveRealtimeLogDeliveryDomainsResponseBodyContent : TeaModel {
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<ListLiveRealtimeLogDeliveryDomainsResponseBodyContentDomains> Domains { get; set; }
            public class ListLiveRealtimeLogDeliveryDomainsResponseBodyContentDomains : TeaModel {
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
        /// <para>95D5B69F-8AEC-419B-8F3A-612B35032B0D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
