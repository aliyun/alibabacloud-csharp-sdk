// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CheckRoleRequest : TeaModel {
        /// <summary>
        /// <para>The role type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EcsRole: access permissions for ECS resources</description></item>
        /// <item><description>CsgRole: permissions to back up Cloud Storage Gateway resources</description></item>
        /// <item><description>NasRole: permissions to back up NAS resources</description></item>
        /// <item><description>OssRole: permissions to back up OSS resources</description></item>
        /// <item><description>UdmRole: permissions to back up entire ECS instances</description></item>
        /// <item><description>VMwareLocalRole: permissions to back up on-premises VMware virtual machines</description></item>
        /// <item><description>VMwareCloudRole: permissions to back up cloud-based VMware virtual machines</description></item>
        /// <item><description>EcsBackupRole: permissions for ECS backup</description></item>
        /// <item><description>OtsRole: permissions to back up OTS resources</description></item>
        /// <item><description>CrossAccountRole: permissions for cross-account backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OssRole</para>
        /// </summary>
        [NameInMap("CheckRoleType")]
        [Validation(Required=false)]
        public string CheckRoleType { get; set; }

        /// <summary>
        /// <para>The name of the RAM role created in the source account for cross-account backup managed by the current account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BackupRole</para>
        /// </summary>
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        /// <summary>
        /// <para>The ID of the source account for cross-account backup managed by the current account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>158975xxxxx4625</para>
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

    }

}
