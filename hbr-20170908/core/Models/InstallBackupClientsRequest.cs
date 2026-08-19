// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class InstallBackupClientsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the RAM role that is created in the source account for cross-account backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BackupRole</para>
        /// </summary>
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        /// <summary>
        /// <para>The type of cross-account backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SELF_ACCOUNT: Backs up data within the current account.</para>
        /// </description></item>
        /// <item><description><para>CROSS_ACCOUNT: Backs up data across accounts.</para>
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
        /// <para>The ID of the source account that is used for cross-account backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16392782xxxxxx</para>
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

        /// <summary>
        /// <para>The IDs of the ECS instances. You can specify a maximum of 20 instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;i-0xi5wj5*****v3j3bh2gj5&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> InstanceIds { get; set; }

    }

}
