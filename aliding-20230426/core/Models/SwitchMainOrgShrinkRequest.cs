// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class SwitchMainOrgShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>21001</para>
        /// </summary>
        [NameInMap("TargetOrgId")]
        [Validation(Required=false)]
        public long? TargetOrgId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

    }

}
