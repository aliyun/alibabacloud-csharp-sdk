// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAvailabilityZonesRequest : TeaModel {
        /// <summary>
        /// <para>The language of the values of the returned <b>RegionName</b> and <b>ZoneName</b> parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The instance type of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds.mongo.standard</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The architecture of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>normal</b>: replica set instance</description></item>
        /// <item><description><b>sharding</b>: sharded cluster instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The database engine version of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The secondary zone ID that is excluded from the query results. You can configure the ExcludeZoneId and ExcludeSecondaryZoneId parameters to specify the IDs of multiple zones that are excluded from the query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-b</para>
        /// </summary>
        [NameInMap("ExcludeSecondaryZoneId")]
        [Validation(Required=false)]
        public string ExcludeSecondaryZoneId { get; set; }

        /// <summary>
        /// <para>The zone ID that is excluded from the query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-g</para>
        /// </summary>
        [NameInMap("ExcludeZoneId")]
        [Validation(Required=false)]
        public string ExcludeZoneId { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b> (default): subscription</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The edition of the instance. High-Available Edition and Preview Edition (dbfs) are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbfs</para>
        /// </summary>
        [NameInMap("MongoType")]
        [Validation(Required=false)]
        public string MongoType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the latest available regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of nodes. This parameter is available only for replica set instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ReplicationFactor")]
        [Validation(Required=false)]
        public string ReplicationFactor { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. For more information, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information of a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmx2m4rqu7pry</para>
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
        /// <para>The storage type of the instance. </para>
        /// <list type="bullet">
        /// <item><description><b>cloud</b>: The system displays only zones in which cloud disk-based instances can be deployed. </description></item>
        /// <item><description><b>local</b>: The system displays only zones in which local disk-based instances can be deployed. </description></item>
        /// <item><description><b>default</b> or null: The system displays only zones in which cloud disk-based and local disk-based instances can be deployed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>local</para>
        /// </summary>
        [NameInMap("StorageSupport")]
        [Validation(Required=false)]
        public string StorageSupport { get; set; }

        /// <summary>
        /// <para>The storage type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_essd1</b>: PL1 enhanced SSD (ESSD)</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD</description></item>
        /// <item><description><b>local_ssd</b>: Local SSD</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Instances that run MongoDB 4.4 or later support only cloud disks. <b>cloud_essd1</b> is selected if you leave this parameter empty.</description></item>
        /// <item><description>Instances that run MongoDB 4.2 and earlier support only local disks. <b>local_ssd</b> is selected if you leave this parameter empty.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query available zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
