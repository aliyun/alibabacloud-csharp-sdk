// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBackupTasksRequest : TeaModel {
        /// <summary>
        /// <para>The backup task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>476****</para>
        /// </summary>
        [NameInMap("BackupJobId")]
        [Validation(Required=false)]
        public int? BackupJobId { get; set; }

        /// <summary>
        /// <para>The backup task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NoStart</b>: not started</description></item>
        /// <item><description><b>Progressing</b>: in progress</description></item>
        /// </list>
        /// <para>Default value: all statuses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoStart</para>
        /// </summary>
        [NameInMap("BackupJobStatus")]
        [Validation(Required=false)]
        public string BackupJobStatus { get; set; }

        /// <summary>
        /// <para>The backup mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Automated</b>: automatic backup</description></item>
        /// <item><description><b>Manual</b>: manual backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Automated</para>
        /// </summary>
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Flag")]
        [Validation(Required=false)]
        public string Flag { get; set; }

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
