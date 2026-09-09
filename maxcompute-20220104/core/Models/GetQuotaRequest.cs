// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetQuotaRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        [NameInMap("AkProven")]
        [Validation(Required=false)]
        [Obsolete]
        public string AkProven { get; set; }

        /// <summary>
        /// <para>Specifies whether to include submodules. Valid values: -true: includes submodules. -false (default): does not include submodules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("mock")]
        [Validation(Required=false)]
        public bool? Mock { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("region")]
        [Validation(Required=false)]
        [Obsolete]
        public string Region { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        [Obsolete]
        public string TenantId { get; set; }

    }

}
