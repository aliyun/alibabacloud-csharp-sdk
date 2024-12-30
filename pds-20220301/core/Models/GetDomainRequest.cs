// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetDomainRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bj1</para>
        /// </summary>
        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the used quota of the domain. Default value: false. If the quota of the domain is greater than 0 and you set this parameter to true, the used quota of the domain is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("get_quota_used")]
        [Validation(Required=false)]
        public bool? GetQuotaUsed { get; set; }

    }

}
