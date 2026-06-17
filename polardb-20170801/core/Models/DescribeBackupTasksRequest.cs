// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBackupTasksRequest : TeaModel {
        /// <summary>
        /// <para>The backup job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11111111</para>
        /// </summary>
        [NameInMap("BackupJobId")]
        [Validation(Required=false)]
        public string BackupJobId { get; set; }

        /// <summary>
        /// <para>The backup mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Automated</b>: An automatic backup.</para>
        /// </description></item>
        /// <item><description><para><b>Manual</b>: A manual backup.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-***************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

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

    }

}
