// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DeleteCrossAccountRequest : TeaModel {
        /// <summary>
        /// <para>The name of the RAM role of the account to back up. This parameter is required when you configure cross-account backup by assuming a RAM role.</para>
        /// <para>This parameter is required.</para>
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
        /// <item><description><para><b>CROSS_ACCOUNT</b>: Cross-account backup is configured by assuming a RAM role.</para>
        /// </description></item>
        /// <item><description><para><b>CROSS_ACCOUNT_BY_RD</b>: Cross-account backup is configured based on a resource directory.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1841xxxxx3649795</para>
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

    }

}
