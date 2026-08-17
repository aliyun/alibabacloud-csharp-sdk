// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class GetCaInstanceCrlAddressRequest : TeaModel {
        /// <summary>
        /// <para>The CA certificate identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1f0167b4-ee84-XXX-49bc4d39fa68</para>
        /// </summary>
        [NameInMap("CaIdentifier")]
        [Validation(Required=false)]
        public string CaIdentifier { get; set; }

        /// <summary>
        /// <para>The zone ID of the China CAS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1f047318-0815-XXX-f7ceb76b5c0a</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
