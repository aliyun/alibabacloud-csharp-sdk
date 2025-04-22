// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class SwitchMainOrgRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>21001</para>
        /// </summary>
        [NameInMap("TargetOrgId")]
        [Validation(Required=false)]
        public long? TargetOrgId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public SwitchMainOrgRequestTenantContext TenantContext { get; set; }
        public class SwitchMainOrgRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
