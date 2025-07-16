// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ChangeDingTalkIdRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4uf_iw54grufg9</para>
        /// </summary>
        [NameInMap("DingTalkId")]
        [Validation(Required=false)]
        public string DingTalkId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public ChangeDingTalkIdRequestTenantContext TenantContext { get; set; }
        public class ChangeDingTalkIdRequestTenantContext : TeaModel {
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
