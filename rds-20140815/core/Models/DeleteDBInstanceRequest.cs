// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DeleteDBInstanceRequest : TeaModel {
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

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The data retention policy for archived backups after the instance is released. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>None</b>: No archived backups are retained.</description></item>
        /// <item><description><b>Lastest</b>: Only the last archived backup is retained.</description></item>
        /// <item><description><b>All</b>: All archived backups are retained.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only for ApsaraDB RDS for MySQL instances with Premium Local SSDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Lastest</para>
        /// </summary>
        [NameInMap("ReleasedKeepPolicy")]
        [Validation(Required=false)]
        public string ReleasedKeepPolicy { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
