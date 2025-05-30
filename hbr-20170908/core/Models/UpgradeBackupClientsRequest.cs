// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpgradeBackupClientsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of Cloud Backup clients. The total number of Cloud Backup client IDs and ECS instance IDs cannot exceed 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;i-0xi5wj******3j3bh2gj5&quot;]</para>
        /// </summary>
        [NameInMap("ClientIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> ClientIds { get; set; }

        /// <summary>
        /// <para>The name of the RAM role that is created within the source Alibaba Cloud account and assigned to the current Alibaba Cloud account to authorize the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbrcrossrole</para>
        /// </summary>
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        /// <summary>
        /// <para>Specifies whether data is backed up within the same Alibaba Cloud account or across Alibaba Cloud accounts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SELF_ACCOUNT: Data is backed up within the same Alibaba Cloud account.</description></item>
        /// <item><description>CROSS_ACCOUNT: Data is backed up across Alibaba Cloud accounts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CROSS_ACCOUNT</para>
        /// </summary>
        [NameInMap("CrossAccountType")]
        [Validation(Required=false)]
        public string CrossAccountType { get; set; }

        /// <summary>
        /// <para>The ID of the source Alibaba Cloud account that authorizes the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1283948272xxxxx</para>
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

        /// <summary>
        /// <para>The IDs of Elastic Compute Service (ECS) instances. The total number of ECS instance IDs and Cloud Backup client IDs cannot exceed 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;c-*********************&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> InstanceIds { get; set; }

    }

}
