// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CheckAlibabaStaffRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>156****9665</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public CheckAlibabaStaffRequestTenantContext TenantContext { get; set; }
        public class CheckAlibabaStaffRequestTenantContext : TeaModel {
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
