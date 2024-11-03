// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ListRealtimeLogDeliveryDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the accelerated domain names.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListRealtimeLogDeliveryDomainsResponseBodyContent Content { get; set; }
        public class ListRealtimeLogDeliveryDomainsResponseBodyContent : TeaModel {
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<ListRealtimeLogDeliveryDomainsResponseBodyContentDomains> Domains { get; set; }
            public class ListRealtimeLogDeliveryDomainsResponseBodyContentDomains : TeaModel {
                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The status. Valid values:</para>
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
