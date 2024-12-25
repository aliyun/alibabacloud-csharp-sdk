// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateDomainExtensionResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the additional domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de-bp1rp7ta19******</para>
        /// </summary>
        [NameInMap("DomainExtensionId")]
        [Validation(Required=false)]
        public string DomainExtensionId { get; set; }

        /// <summary>
        /// <para>The frontend port that is used by the SLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A6E7EFC9-0938-40CA-877D-9BEDBD21D357</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
