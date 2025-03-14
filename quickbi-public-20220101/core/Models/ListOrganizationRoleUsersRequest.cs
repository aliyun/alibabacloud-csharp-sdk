// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListOrganizationRoleUsersRequest : TeaModel {
        /// <summary>
        /// <para>Keyword for the nickname of the organization member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhangsan</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>Page number.</para>
        /// <list type="bullet">
        /// <item><description>Default value is 1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>Number of items per page.</para>
        /// <list type="bullet">
        /// <item><description>Default value is 10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Organization role ID, including predefined roles and custom roles:</para>
        /// <list type="bullet">
        /// <item><description>Organization Administrator (predefined role): 111111111</description></item>
        /// <item><description>Permission Administrator (predefined role): 111111112</description></item>
        /// <item><description>Regular User (predefined role): 111111113</description></item>
        /// <item><description>Custom Role: The corresponding role ID for a custom role</description></item>
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
