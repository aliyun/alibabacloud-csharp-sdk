// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class AttachRCDiskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the cloud disk is released when the instance is released. Valid values:</para>
        /// <para>true: The cloud disk is released when the instance is released.
        /// false: The cloud disk is not released when the instance is released. The cloud disk is retained as a pay-as-you-go data cloud disk.
        /// Default value: false.</para>
        /// <para>When you configure this parameter, take note of the following items:</para>
        /// <para>If you set DeleteWithInstance to false and the instance is locked for security reasons, meaning that OperationLocks contains &quot;LockReason&quot; : &quot;security&quot;, this parameter is ignored and the cloud disk is released along with the instance.</para>
        /// <para>If the cloud disk to be attached is an elastic ephemeral disk, you must set DeleteWithInstance to true.</para>
        /// <para>This parameter is not supported for cloud disks that have the multi-attach feature enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeleteWithInstance")]
        [Validation(Required=false)]
        public bool? DeleteWithInstance { get; set; }

        /// <summary>
        /// <para>The ID of the cloud disk to be attached. The cloud disk (DiskId) and the instance (InstanceId) must be in the same zone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rcd-wz98hnpj2sjo85zc7t2w</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>The ID of the destination RDS Custom instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-dh2jf9n6j4s14926****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
