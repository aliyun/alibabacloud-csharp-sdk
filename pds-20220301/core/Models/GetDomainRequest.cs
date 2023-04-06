// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetDomainRequest : TeaModel {
        /// <summary>
        /// domain id
        /// </summary>
        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("get_quota_used")]
        [Validation(Required=false)]
        public bool? GetQuotaUsed { get; set; }

    }

}
