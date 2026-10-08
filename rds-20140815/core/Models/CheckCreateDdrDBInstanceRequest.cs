// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CheckCreateDdrDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup set used for restoration from a backup set. You can call the DescribeCrossRegionBackups operation to query the backup set ID.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>RestoreType</b> is set to <b>0</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>14358</para>
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// <para>The instance type of the destination instance. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Instance types</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds.mysql.s1.small</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The instance storage of the destination instance. Valid values: <b>5 to 2000</b>. The value is incremented in steps of 5 GB. Unit: GB. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Instance types</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The type of the destination database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>SQLServer</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The version of the destination database engine. The valid values vary based on the value of <b>Engine</b>.</para>
        /// <list type="bullet">
        /// <item><description>MySQL: <b>5.5/5.6/5.7/8.0</b></description></item>
        /// <item><description>SQL Server: <b>2008r2 (instances with Premium Local SSDs, discontinued)/08r2_ent_ha (instances with cloud disks, discontinued)/2012/2012_ent_ha/2012_std_ha/2012_web/2014_std_ha/2016_ent_ha/2016_std_ha/2016_web/2017_std_ha/2017_ent/2019_std_ha/2019_ent</b></description></item>
        /// <item><description>PostgreSQL: <b>10.0/11.0/12.0/13.0/14.0/15.0</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>For SQL Server instances, <c>_ent</c> indicates Enterprise Cluster Edition, <c>_ent_ha</c> indicates Enterprise Edition, <c>_std_ha</c> indicates Standard Edition, and <c>_web</c> indicates Web Edition.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.6</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the destination instance. You can call the DescribeRegions operation to query the region ID.</para>
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
        /// <para>The point in time to which you want to restore data when you restore data to a point in time. The point in time must be earlier than the current time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
        /// <remarks>
        /// <para>This parameter is required when <b>RestoreType</b> is set to <b>1</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-05-30T03:29:10Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The restoration method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): restores data from a backup set. If you set this parameter to 0, you must also specify <b>BackupSetId</b>.</description></item>
        /// <item><description><b>1</b>: restores data to a point in time. If you set this parameter to 1, you must also specify <b>RestoreTime</b>, <b>SourceRegion</b>, and <b>SourceDBInstanceName</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RestoreType")]
        [Validation(Required=false)]
        public string RestoreType { get; set; }

        /// <summary>
        /// <para>The ID of the source instance when you restore data to a point in time.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>RestoreType</b> is set to <b>1</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("SourceDBInstanceName")]
        [Validation(Required=false)]
        public string SourceDBInstanceName { get; set; }

        /// <summary>
        /// <para>The ID of the source region when you restore data to a point in time.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>RestoreType</b> is set to <b>1</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceRegion")]
        [Validation(Required=false)]
        public string SourceRegion { get; set; }

    }

}
