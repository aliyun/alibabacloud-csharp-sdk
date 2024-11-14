// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribePunishedDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain names that are penalized for failing to obtain an ICP filing.</para>
        /// </summary>
        [NameInMap("PunishedDomains")]
        [Validation(Required=false)]
        public List<string> PunishedDomains { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B1F4D802-55A1-5D53-A247-7E79****85E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
