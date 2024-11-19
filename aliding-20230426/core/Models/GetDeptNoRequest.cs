// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetDeptNoRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetDeptNoRequestTenantContext TenantContext { get; set; }
        public class GetDeptNoRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>012345</para>
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public string DeptId { get; set; }

    }

}
