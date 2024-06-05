// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetDomainRequest : TeaModel {
        /// <summary>
        /// The ID of the domain.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        /// <summary>
        /// Specifies whether to return the used quota of the domain. Default value: false. If the quota of the domain is greater than 0 and you set this parameter to true, the used quota of the domain is returned.
        /// </summary>
        [NameInMap("get_quota_used")]
        [Validation(Required=false)]
        public bool? GetQuotaUsed { get; set; }

    }

}
