// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListSpareIpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6FEA0CF3-D3B9-43E5-A304-D217037876A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The secondary IP addresses that are associated with the CNAME.</para>
        /// </summary>
        [NameInMap("SpareIps")]
        [Validation(Required=false)]
        public List<ListSpareIpsResponseBodySpareIps> SpareIps { get; set; }
        public class ListSpareIpsResponseBodySpareIps : TeaModel {
            /// <summary>
            /// <para>The secondary IP address that is associated with the CNAME. If the acceleration area becomes unavailable, GA redirects traffic to the secondary IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX</para>
            /// </summary>
            [NameInMap("SpareIp")]
            [Validation(Required=false)]
            public string SpareIp { get; set; }

            /// <summary>
            /// <para>The status of the secondary IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>active:</b> The secondary IP address is available.</description></item>
            /// <item><description><b>inuse:</b> The secondary IP address is in use.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
