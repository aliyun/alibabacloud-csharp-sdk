// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CreateDataImportTaskRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. &gt; You can call the <a href="https://help.aliyun.com/document_detail/196830.html">DescribeDBInstances</a> operation to query the details of all instances in the destination region, including instance IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-********</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The execution environment for importing the destination SQL. Valid values: <b>importing</b>: Importing. <b>success</b>: Import succeeded. <b>fail</b>: Import failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>transfer_test3</para>
        /// </summary>
        [NameInMap("DstDb")]
        [Validation(Required=false)]
        public string DstDb { get; set; }

        /// <summary>
        /// <para>The password of the privileged account of the destination ApsaraDB RDS instance. This parameter takes effect only when [unk]dstpassword=true[unk].</para>
        /// 
        /// <b>Example:</b>
        /// <para>DemoPass1@</para>
        /// </summary>
        [NameInMap("DstPassword")]
        [Validation(Required=false)]
        public string DstPassword { get; set; }

        /// <summary>
        /// <para>The migration task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-shr8****k36vrn</para>
        /// </summary>
        [NameInMap("DstResId")]
        [Validation(Required=false)]
        public string DstResId { get; set; }

        /// <summary>
        /// <para>The destination username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bbt_cms_prod</para>
        /// </summary>
        [NameInMap("DstUserName")]
        [Validation(Required=false)]
        public string DstUserName { get; set; }

        /// <summary>
        /// <para>The region where the instance resides. &gt; You can call the <a href="https://help.aliyun.com/document_detail/196841.html">DescribeRegions</a> operation to query the details of regions supported by PolarDB-X, including region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The import task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>etx-szr2rr6i*****</para>
        /// </summary>
        [NameInMap("SlinkTaskId")]
        [Validation(Required=false)]
        public string SlinkTaskId { get; set; }

        /// <summary>
        /// <para>The database information of the migration source when the source database is ApsaraDB RDS for MySQL. &gt; The source database must be consistent with the destination database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>transfer_for_st</para>
        /// </summary>
        [NameInMap("SrcDb")]
        [Validation(Required=false)]
        public string SrcDb { get; set; }

        /// <summary>
        /// <para>The read/write mode for executing the import task on the source end. Valid values: <b>rw</b>: Read and write. <b>ro</b>: Read-only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw</para>
        /// </summary>
        [NameInMap("SrcPassword")]
        [Validation(Required=false)]
        public string SrcPassword { get; set; }

        /// <summary>
        /// <para>The source ApsaraDB RDS instance ID. &gt; You can call the <a href="https://help.aliyun.com/document_detail/196830.html">DescribeDrivingAccess</a> operation to query the details of all source ApsaraDB RDS instances in the destination region, including instance IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-shrnv****kh87z</para>
        /// </summary>
        [NameInMap("SrcResId")]
        [Validation(Required=false)]
        public string SrcResId { get; set; }

        /// <summary>
        /// <para>The source username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds_test</para>
        /// </summary>
        [NameInMap("SrcUserName")]
        [Validation(Required=false)]
        public string SrcUserName { get; set; }

    }

}
