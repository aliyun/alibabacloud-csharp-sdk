// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DeleteSandboxInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup schedule. You can call the <a href="https://help.aliyun.com/document_detail/437215.html">DescribeBackupPlanList</a> operation to query the ID of the backup schedule.</para>
        /// <remarks>
        /// <para>If your instance is an ApsaraDB RDS for MySQL instance, you can <a href="https://help.aliyun.com/document_detail/193091.html">configure automatic access to a data source</a> to automatically add the instance to DBS and obtain the ID of the backup schedule.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1hxxxx8xxxxxa</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>The ID of the sandbox instance. You can call the <a href="https://help.aliyun.com/document_detail/437257.html">DescribeSandboxInstances</a> operation to query the ID of the sandbox instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1jxxxxnxxx1xc</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
