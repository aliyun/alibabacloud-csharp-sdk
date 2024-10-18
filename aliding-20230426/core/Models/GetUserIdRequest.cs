// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetUserIdRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public GetUserIdRequestTenantContext TenantContext { get; set; }
        public class GetUserIdRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>unionId</para>
        /// 
        /// <b>Example:</b>
        /// <para>****iE</para>
        /// </summary>
        [NameInMap("UnionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
