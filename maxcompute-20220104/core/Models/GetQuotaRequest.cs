// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetQuotaRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The trusted AccessKey pairs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("AkProven")]
        [Validation(Required=false)]
        [Obsolete]
        public string AkProven { get; set; }

        /// <summary>
        /// <para>Specifies whether to include submodules. Valid values: -true: The request includes submodules. -false: The request does not include submodules. This is the default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("mock")]
        [Validation(Required=false)]
        public bool? Mock { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        [Obsolete]
        public string Region { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>520539530998273</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        [Obsolete]
        public string TenantId { get; set; }

    }

}
