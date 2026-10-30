// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouterMulticastDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94E19C6F-206F-5223-9A63-64B85851BC04</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the multicast domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-mcast-domain-40cwj0rgzgdtam****</para>
        /// </summary>
        [NameInMap("TransitRouterMulticastDomainId")]
        [Validation(Required=false)]
        public string TransitRouterMulticastDomainId { get; set; }

    }

}
