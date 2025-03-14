// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryOrganizationRoleConfigRequest : TeaModel {
        /// <summary>
        /// <para>Organization role ID, including predefined roles and custom roles:</para>
        /// <list type="bullet">
        /// <item><description>Organization Administrator (predefined role): 111111111</description></item>
        /// <item><description>Permission Administrator (predefined role): 111111112</description></item>
        /// <item><description>Regular User (predefined role): 111111113</description></item>
        /// <item><description>Custom Role: The corresponding role ID of the custom role</description></item>
        /// </list>
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
