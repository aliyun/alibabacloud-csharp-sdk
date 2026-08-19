// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DeleteSnapshotRequest : TeaModel {
        /// <summary>
        /// <para>The client ID. When deleting a backup snapshot of ECS File Backup Essential Edition, you must specify either this parameter or <b>InstanceId</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-*********************</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The ECS instance ID. When deleting a backup snapshot of ECS File Backup Essential Edition, you must specify either this parameter or <b>ClientId</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-*********************</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The backup snapshot ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-*********************</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The backup source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS_FILE</b>: backup snapshot of ECS File Backup Essential Edition.</description></item>
        /// <item><description><b>OSS</b>: backup snapshot of Alibaba Cloud OSS.</description></item>
        /// <item><description><b>NAS</b>: backup snapshot of Alibaba Cloud NAS.</description></item>
        /// <item><description><b>UDM_ECS</b>: backup snapshot of an entire ECS instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_FILE</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The token for the deletion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02WJDOE7</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The backup vault ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-*********************</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
