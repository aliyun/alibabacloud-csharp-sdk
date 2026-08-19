// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class AddCrossAccountRequest : TeaModel {
        /// <summary>
        /// <para>The alias. The maximum length is 32 characters. This parameter is not required for cross-account backups that are configured based on a resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Source account 1</para>
        /// </summary>
        [NameInMap("Alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>The name of the RAM role for the account to back up. This parameter is used when you configure a cross-account backup by assuming a RAM role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbrcrossrole</para>
        /// </summary>
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        /// <summary>
        /// <para>The type of cross-account backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CROSS_ACCOUNT</b>: Configures a cross-account backup by assuming a RAM role.</para>
        /// </description></item>
        /// <item><description><para><b>CROSS_ACCOUNT_BY_RD</b>: Configures a cross-account backup based on a resource directory.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CROSS_ACCOUNT</para>
        /// </summary>
        [NameInMap("CrossAccountType")]
        [Validation(Required=false)]
        public string CrossAccountType { get; set; }

        /// <summary>
        /// <para>The UID of the account to back up.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1589753xxxxxx625</para>
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

    }

}
