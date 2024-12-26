// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaRestoresRequest : TeaModel {
        /// <summary>
        /// <para>The backup ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1632754800158</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public long? BackupId { get; set; }

        /// <summary>
        /// <para>The ID of the SAP HANA instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cl-000b******soejg</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEMDB</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 99. Default value: 10.\`</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm4ebtpkzx7zy</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the restore job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-0007o3vqfukfe92hvf13</para>
        /// </summary>
        [NameInMap("RestoreId")]
        [Validation(Required=false)]
        public string RestoreId { get; set; }

        /// <summary>
        /// <para>The status of the restore job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RUNNING</b>: The job is running.</description></item>
        /// <item><description><b>COMPLETE</b>: The job is completed.</description></item>
        /// <item><description><b>PARTIAL_COMPLETE</b>: The job is partially completed.</description></item>
        /// <item><description><b>FAILED</b>: The job failed.</description></item>
        /// <item><description><b>CANCELED</b>: The job is canceled.</description></item>
        /// <item><description><b>EXPIRED</b>: The job timed out.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETE</para>
        /// </summary>
        [NameInMap("RestoreStatus")]
        [Validation(Required=false)]
        public string RestoreStatus { get; set; }

        /// <summary>
        /// <para>The ID of the backup vault.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-000au6bq******mpu</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
