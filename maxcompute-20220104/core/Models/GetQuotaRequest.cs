// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetQuotaRequest : TeaModel {
        /// <summary>
        /// The trusted AccessKey pairs.
        /// </summary>
        [NameInMap("AkProven")]
        [Validation(Required=false)]
        public string AkProven { get; set; }

        /// <summary>
        /// Specifies whether to include submodules. Valid values: -true: The request includes submodules. -false: The request does not include submodules. This is the default value.
        /// </summary>
        [NameInMap("mock")]
        [Validation(Required=false)]
        public bool? Mock { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The tenant ID.
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
