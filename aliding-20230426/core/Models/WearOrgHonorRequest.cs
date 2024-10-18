// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class WearOrgHonorRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public WearOrgHonorRequestTenantContext TenantContext { get; set; }
        public class WearOrgHonorRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>306752103647458</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21659595</para>
        /// </summary>
        [NameInMap("honorId")]
        [Validation(Required=false)]
        public string HonorId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("wear")]
        [Validation(Required=false)]
        public bool? Wear { get; set; }

    }

}
