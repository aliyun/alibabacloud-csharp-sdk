// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetUserRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the tenant to which the task belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The WINNEXO logon account. This is a unique identifier and cannot be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleAccountId</para>
        /// </summary>
        [NameInMap("wnAccountId")]
        [Validation(Required=false)]
        public string WnAccountId { get; set; }

        /// <summary>
        /// <para>The WINNEXO platform user ID. Specify either this parameter or accountId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("wnUserId")]
        [Validation(Required=false)]
        public string WnUserId { get; set; }

    }

}
