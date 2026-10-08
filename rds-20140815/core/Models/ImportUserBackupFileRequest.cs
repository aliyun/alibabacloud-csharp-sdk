// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ImportUserBackupFileRequest : TeaModel {
        /// <summary>
        /// <para>A JSON array that describes the backup file information in the OSS bucket. Example:
        /// <c>{&quot;Bucket&quot;:&quot;test&quot;, &quot;Object&quot;:&quot;test/test_db_employees.xb&quot;,&quot;Location&quot;:&quot;ap-southeast-1&quot;}</c></para>
        /// <para>The following list describes the parameters in the array:</para>
        /// <list type="bullet">
        /// <item><description><b>Bucket</b>: the name of the OSS bucket that stores the backup file. You can call <a href="https://help.aliyun.com/document_detail/31965.html">GetBucket</a> to query the bucket name.</description></item>
        /// <item><description><b>Object</b>: the full path of the backup file in the directory. You can call <a href="https://help.aliyun.com/document_detail/31980.html">GetObject</a> to query the path.</description></item>
        /// <item><description><b>Location</b>: the region ID of the OSS bucket. You can call <a href="https://help.aliyun.com/document_detail/31967.html">GetBucketLocation</a> to query the region ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Bucket&quot;:&quot;test&quot;, &quot;Object&quot;:&quot;test/test_db_employees.xb&quot;,&quot;Location&quot;:&quot;ap-southeast-1&quot;}</para>
        /// </summary>
        [NameInMap("BackupFile")]
        [Validation(Required=false)]
        public string BackupFile { get; set; }

        /// <summary>
        /// <para>The region ID of the OSS bucket that stores the backup file of the self-managed MySQL 5.7 database. You can call DescribeRegions to query the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BucketRegion")]
        [Validation(Required=false)]
        public string BucketRegion { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically set up replication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: automatically sets up replication. The <c>MasterInfo</c> parameter is required.</description></item>
        /// <item><description>false: does not set up replication.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only for native replication instances. You must specify the <c>DBInstanceId</c> parameter when you call this operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("BuildReplication")]
        [Validation(Required=false)]
        public bool? BuildReplication { get; set; }

        /// <summary>
        /// <para>The description of the user backup to be imported.</para>
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
        /// <para>The version of the MySQL database engine. Valid values: <b>5.7</b> and <b>8.0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.7</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>A JSON array that contains the master information for setting up MySQL replication (case-sensitive). Example:</para>
        /// <pre><c>{&quot;masterIp&quot;:&quot;172.20.xx.xx&quot;,&quot;masterPort&quot;:&quot;3306&quot;,&quot;masterUser&quot;:&quot;replica&quot;,&quot;masterPassword&quot;:&quot;W33uopkehBQ=&quot;}
        /// </c></pre>
        /// <para>The following list describes the parameters in the array:</para>
        /// <list type="bullet">
        /// <item><description><c>masterIp</c>: the IP address of the primary database.</description></item>
        /// <item><description><c>masterPort</c>: the port of the primary database.</description></item>
        /// <item><description><c>masterUser</c>: the replication account of the primary database.</description></item>
        /// <item><description><c>masterPassword</c>: the password of the replication account for the primary database. The password must be Base64-encoded.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only for native replication instances. You must specify the <c>DBInstanceId</c> parameter when you call this operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;masterIp&quot;:&quot;172.20.xx.xx&quot;,&quot;masterPort&quot;:&quot;3306&quot;,&quot;masterUser&quot;:&quot;replica&quot;,&quot;masterPassword&quot;:&quot;W33uopkehBQ=&quot;}</para>
        /// </summary>
        [NameInMap("MasterInfo")]
        [Validation(Required=false)]
        public string MasterInfo { get; set; }

        /// <summary>
        /// <para>The import mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>oss: imports the backup from OSS.</description></item>
        /// <item><description>stream: imports the backup over the network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the ApsaraDB RDS instance. You can call DescribeRegions to query the region ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The value of this parameter specifies the region ID in which you want to create the ApsaraDB RDS instance.</description></item>
        /// <item><description>The value must be the same as the value of the <b>BucketRegion</b> parameter.</description></item>
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
        /// <para>The resource group ID. You can call DescribeDBInstanceAttribute to query the resource group ID.</para>
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
        /// <para>The storage space required to restore the user backup. Unit: GB.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The default value is five times the size of the backup file.</description></item>
        /// <item><description>The minimum value is 20.</description></item>
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
        /// <para>The retention period of the user backup file. Unit: days. The value must be an integer greater than <b>0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

        /// <summary>
        /// <para>A JSON array that provides the source information for the full backup (case-sensitive). Example:</para>
        /// <pre><c>{&quot;sourceIp&quot;:&quot;172.20.xx
        /// .xx&quot;,&quot;sourcePort&quot;:&quot;9999&quot;}
        /// </c></pre>
        /// <para>The following list describes the parameters in the array:</para>
        /// <list type="bullet">
        /// <item><description><para><c>sourceIp</c>: the source IP address.</para>
        /// </description></item>
        /// <item><description><para><c>sourcePort</c>: the Netcat listening port on the source.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only for native replication instances. You must specify the <c>DBInstanceId</c> parameter when you call this operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;sourceIp&quot;:&quot;172.20.xx.xx&quot;,&quot;sourcePort&quot;:&quot;9999&quot;}</para>
        /// </summary>
        [NameInMap("SourceInfo")]
        [Validation(Required=false)]
        public string SourceInfo { get; set; }

        /// <summary>
        /// <para>The zone ID. You can call DescribeRegions to query the zone ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>After you specify a zone, the system creates a second-level snapshot in the zone, which significantly reduces the time required for backup import.</description></item>
        /// <item><description>When you call CreateDBInstance to create an instance from the user backup, this zone is the zone in which the new instance resides.</description></item>
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
