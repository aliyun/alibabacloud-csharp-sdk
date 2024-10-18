// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class RecallHonorRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public RecallHonorRequestTenantContext TenantContext { get; set; }
        public class RecallHonorRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21660610</para>
        /// </summary>
        [NameInMap("honorId")]
        [Validation(Required=false)]
        public string HonorId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>345391052</para>
        /// </summary>
        [NameInMap("orgId")]
        [Validation(Required=false)]
        public long? OrgId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>363784</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
