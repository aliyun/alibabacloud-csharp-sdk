// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DeleteSnapshotRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud Backup client. If you delete a backup snapshot for Elastic Compute Service (ECS) instances, you must specify one of the ClientId and <b>InstanceId</b> parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-*********************</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly delete the most recent backup snapshot. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The system forcibly deletes the most recent backup snapshot.</description></item>
        /// <item><description>false (default): The system does not forcibly delete the most recent backup snapshot.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The ID of the ECS instance. If you delete a backup snapshot for ECS instances, you must specify one of the InstanceId and <b>ClientId</b> parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-*********************</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the backup snapshot.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-*********************</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The type of the backup source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS_FILE</b>: backup snapshots for ECS files</description></item>
        /// <item><description><b>OSS</b>: backup snapshots for Object Storage Service (OSS) buckets</description></item>
        /// <item><description><b>NAS</b>: backup snapshots for Apsara File Storage NAS (NAS) file systems</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_FILE</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The token that you want to delete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02WJDOE7</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The ID of the backup vault.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-*********************</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
