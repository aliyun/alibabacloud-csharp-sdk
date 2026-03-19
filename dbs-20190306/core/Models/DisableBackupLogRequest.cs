// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DisableBackupLogRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup plan. Call <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> to query it.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbstooi01****</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>Ensures idempotence and prevents duplicate requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCziJZNwH****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableMysqlPhysicalBackupBinlogOnly")]
        [Validation(Required=false)]
        public string DisableMysqlPhysicalBackupBinlogOnly { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

    }

}
