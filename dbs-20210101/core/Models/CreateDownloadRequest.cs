// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class CreateDownloadRequest : TeaModel {
        [NameInMap("AdminDatabase")]
        [Validation(Required=false)]
        public string AdminDatabase { get; set; }

        /// <summary>
        /// <para>The ID of the backup set. You can call the <a href="https://help.aliyun.com/document_detail/26273.html">DescribeBackups</a> operation to query the ID of the backup set.</para>
        /// <remarks>
        /// <para>This parameter is required if the BakSetType parameter is set to full.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>146005****</para>
        /// </summary>
        [NameInMap("BakSetId")]
        [Validation(Required=false)]
        public string BakSetId { get; set; }

        /// <summary>
        /// <para>The size of the full backup set. Unit: bytes. You can call the <a href="https://help.aliyun.com/document_detail/26273.html">DescribeBackups</a> operation to query the size of the full backup set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>216****</para>
        /// </summary>
        [NameInMap("BakSetSize")]
        [Validation(Required=false)]
        public string BakSetSize { get; set; }

        /// <summary>
        /// <para>The type of the download task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>full</b>: downloads a full backup set.</description></item>
        /// <item><description><b>pitr</b>: downloads a backup set at a specific point in time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>full</para>
        /// </summary>
        [NameInMap("BakSetType")]
        [Validation(Required=false)]
        public string BakSetType { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The point in time at which the backup set is downloaded. Specify a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <remarks>
        /// <para>This parameter is required if the BakSetType parameter is set to pitr.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1661331864000</para>
        /// </summary>
        [NameInMap("DownloadPointInTime")]
        [Validation(Required=false)]
        public string DownloadPointInTime { get; set; }

        /// <summary>
        /// <para>The format to which the downloaded backup set is converted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CSV</b></description></item>
        /// <item><description><b>SQL</b></description></item>
        /// <item><description><b>Parquet</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CSV</para>
        /// </summary>
        [NameInMap("FormatType")]
        [Validation(Required=false)]
        public string FormatType { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-wz994c1t1****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("IsCluster")]
        [Validation(Required=false)]
        public string IsCluster { get; set; }

        [NameInMap("IsPhysical")]
        [Validation(Required=false)]
        public bool? IsPhysical { get; set; }

        [NameInMap("PrimaryKeyTypeOnly")]
        [Validation(Required=false)]
        public string PrimaryKeyTypeOnly { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the instance resides. You can call the <a href="https://help.aliyun.com/document_detail/26231.html">DescribeDBInstanceAttribute</a> operation to query the region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionCode")]
        [Validation(Required=false)]
        public string RegionCode { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket that is used to store the backup set.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is required if the TargetType parameter is set to OSS.</description></item>
        /// <item><description>Make sure that your account is granted the <b>AliyunDBSDefaultRole</b> permission. For more information, see <a href="https://help.aliyun.com/document_detail/26307.html">Use RAM for resource authorization</a>. You can also grant permissions based on the operation instructions in the Resource Access Management (RAM) console.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("TargetBucket")]
        [Validation(Required=false)]
        public string TargetBucket { get; set; }

        /// <summary>
        /// <para>The region in which the OSS bucket resides.</para>
        /// <remarks>
        /// <para>This parameter is required if the TargetType parameter is set to OSS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("TargetOssRegion")]
        [Validation(Required=false)]
        public string TargetOssRegion { get; set; }

        /// <summary>
        /// <para>The destination path to which the backup set is downloaded.</para>
        /// <remarks>
        /// <para>This parameter is required if the TargetType parameter is set to OSS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test_db/path</para>
        /// </summary>
        [NameInMap("TargetPath")]
        [Validation(Required=false)]
        public string TargetPath { get; set; }

        /// <summary>
        /// <para>The type of the destination to which the backup set is downloaded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OSS</b></description></item>
        /// <item><description><b>URL</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        [NameInMap("UseZstd")]
        [Validation(Required=false)]
        public string UseZstd { get; set; }

    }

}
