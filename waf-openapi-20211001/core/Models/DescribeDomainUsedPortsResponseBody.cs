// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDomainUsedPortsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-<em>-A47C-</em></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsedPorts")]
        [Validation(Required=false)]
        public List<int?> UsedPorts { get; set; }

    }

}
