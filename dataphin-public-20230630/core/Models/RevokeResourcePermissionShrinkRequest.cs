// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class RevokeResourcePermissionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The authorization revocation request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RevokeCommand")]
        [Validation(Required=false)]
        public string RevokeCommandShrink { get; set; }

    }

}
