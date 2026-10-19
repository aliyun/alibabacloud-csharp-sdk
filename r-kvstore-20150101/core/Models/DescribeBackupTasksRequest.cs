// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeBackupTasksRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup task.</para>
        /// <remarks>
        /// <para>If you called the <a href="https://help.aliyun.com/document_detail/473819.html">CreateBackup</a> operation to perform a manual backup, you can pass the returned backup ID to query the backup progress.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1162****</para>
        /// </summary>
        [NameInMap("BackupJobId")]
        [Validation(Required=false)]
        public string BackupJobId { get; set; }

        /// <summary>
        /// <para>The ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/473778.html">DescribeInstances</a> operation to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The backup mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Automated</b>: automated backup. You can call the <a href="https://help.aliyun.com/document_detail/473822.html">DescribeBackupPolicy</a> operation to query the automatic backup policy.</description></item>
        /// <item><description><b>Manual</b>: manual backup.<remarks>
        /// <para>By default, task information for all backup modes is returned.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("JobMode")]
        [Validation(Required=false)]
        public string JobMode { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
