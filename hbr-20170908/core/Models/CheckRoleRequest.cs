// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CheckRoleRequest : TeaModel {
        /// <summary>
        /// <para>The type of the role. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EcsRole: a role with the permissions to access Elastic Compute Service (ECS) resources</description></item>
        /// <item><description>CsgRole: a role with the permissions to perform Cloud Storage Gateway (CSG) backup</description></item>
        /// <item><description>NasRole: a role with the permissions to perform NAS backup</description></item>
        /// <item><description>OssRole: a role with the permissions to perform Object Storage Service (OSS) backup</description></item>
        /// <item><description>UdmRole: a role with the permissions to perform ECS instance backup</description></item>
        /// <item><description>VMwareLocalRole: a role with the permissions to back up on-premises VMware virtual machines (VMs)</description></item>
        /// <item><description>VMwareCloudRole: a role with the permissions to back up VMs deployed on Alibaba Cloud VMware Service (ACVS)</description></item>
        /// <item><description>EcsBackupRole: a role with the permissions to perform ECS backup</description></item>
        /// <item><description>OtsRole: a role with the permissions to perform Tablestore backup</description></item>
        /// <item><description>CrossAccountRole: a role with the permissions to perform cross-account backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OssRole</para>
        /// </summary>
        [NameInMap("CheckRoleType")]
        [Validation(Required=false)]
        public string CheckRoleType { get; set; }

        /// <summary>
        /// <para>The name of the Resource Access Management (RAM) role that is created within the source Alibaba Cloud account and assigned to the current Alibaba Cloud account to authorize the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BackupRole</para>
        /// </summary>
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        /// <summary>
        /// <para>The ID of the source Alibaba Cloud account that authorizes the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>158975xxxxx4625</para>
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

    }

}
