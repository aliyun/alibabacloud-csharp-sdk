// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class EnableBackupLogRequest : TeaModel {
        /// <summary>
        /// <para>The backup plan ID. Call <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbstooi******</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>A client-generated token that ensures the idempotency of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbs</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable log backup for MySQL physical backups. Set the value to <c>true</c> to enable this feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableMysqlPhysicalBackupBinlog")]
        [Validation(Required=false)]
        public string EnableMysqlPhysicalBackupBinlog { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

    }

}
