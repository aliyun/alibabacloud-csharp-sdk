// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ImportUserBackupFileRequest : TeaModel {
        /// <summary>
        /// <para>A JSON array that consists of the information about the full backup file stored as an object in an OSS bucket. Example: <c>{&quot;Bucket&quot;:&quot;test&quot;, &quot;Object&quot;:&quot;test/test_db_employees.xb&quot;,&quot;Location&quot;:&quot;ap-southeast-1&quot;}</c></para>
        /// <para>The JSON array contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>Bucket</b>: The name of the OSS bucket in which the full backup file is stored as an object. You can call the <a href="https://help.aliyun.com/document_detail/31965.html">GetBucket</a> operation to query the name of the bucket.</description></item>
        /// <item><description><b>Object</b>: The path of the full backup file that is stored as an object in the OSS bucket. You can call the <a href="https://help.aliyun.com/document_detail/31980.html">GetObject</a> operation to query the path of the object.</description></item>
        /// <item><description><b>Location</b>: The ID of the region in which the OSS bucket is located. You can call the <a href="https://help.aliyun.com/document_detail/31967.html">GetBucketLocation</a> operation to query the region of the bucket.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Bucket&quot;:&quot;test&quot;, &quot;Object&quot;:&quot;test/test_db_employees.xb&quot;,&quot;Location&quot;:&quot;ap-southeast-1&quot;}</para>
        /// </summary>
        [NameInMap("BackupFile")]
        [Validation(Required=false)]
        public string BackupFile { get; set; }

        /// <summary>
        /// <para>The region ID of the OSS bucket where the full backup file of the self-managed MySQL database is located. You can call the DescribeRegions operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BucketRegion")]
        [Validation(Required=false)]
        public string BucketRegion { get; set; }

        /// <summary>
        /// <para>The description of the full backup file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BackupTest</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The version of the database engine that is run on the self-managed MySQL database and ApsaraDB RDS for MySQL instance. Set the value to <b>5.7</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.7</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the DescribeRegions operation to query the most recent region list.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The value of this parameter is the ID of the region in which you want to create the instance.</description></item>
        /// <item><description>The value of this parameter must be consistent with the value of <b>BucketRegion</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. You can call the DescribeDBInstanceAttribute operation to query the resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The amount of storage that is required to restore the data of the full backup file. Unit: GB.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The default value of this parameter is 5 times the size of the full backup file.</description></item>
        /// <item><description>The minimum value of this parameter is 20.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("RestoreSize")]
        [Validation(Required=false)]
        public int? RestoreSize { get; set; }

        /// <summary>
        /// <para>The retention period of the full backup file. Unit: days. Valid values: any <b>non-zero</b> positive integer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

        /// <summary>
        /// <para>The zone ID. You can call the DescribeRegions operation to query the zone ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, the system creates a snapshot in single-digit seconds, which greatly reduces the time that is required to import the full backup file.</description></item>
        /// <item><description>When you call the CreateDBInstance operation to create an instance by using the full backup file, the instance is created in the zone that you specify for this parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
