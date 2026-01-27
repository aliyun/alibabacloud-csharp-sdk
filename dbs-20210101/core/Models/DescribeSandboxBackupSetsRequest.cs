// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DescribeSandboxBackupSetsRequest : TeaModel {
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
        /// <para>The ID of the backup set. If this parameter is specified, only the snapshot of the specified backup set is returned. If this parameter is not specified, all the snapshots of the backup schedule are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1xxxx2xxxxx1e</para>
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>30: This is the default value.</description></item>
        /// <item><description>50\.</description></item>
        /// <item><description>100\.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
