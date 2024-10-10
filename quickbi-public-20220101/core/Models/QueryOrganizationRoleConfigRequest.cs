// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryOrganizationRoleConfigRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111111111</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public long? RoleId { get; set; }

    }

}
