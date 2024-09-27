// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ChangeDomainOfDnsProductResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain name that is originally bound to the instance. If no value is returned for this parameter, the instance is bound to a domain name for the first time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>originaldomain.com</para>
        /// </summary>
        [NameInMap("OriginalDomain")]
        [Validation(Required=false)]
        public string OriginalDomain { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
