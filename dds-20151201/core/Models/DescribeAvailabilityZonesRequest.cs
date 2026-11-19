// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAvailabilityZonesRequest : TeaModel {
        /// <summary>
        /// <para>The language of the <b>RegionName</b> and <b>ZoneName</b> response parameters. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese. Default value.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds.mongo.standard</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The database type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>normal</b>: replica set instance.</description></item>
        /// <item><description><b>sharding</b>: sharded cluster instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The database engine version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The secondary zone ID to be excluded from the query results in the current region. This parameter is used together with ExcludeZoneId to filter multiple zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-b</para>
        /// </summary>
        [NameInMap("ExcludeSecondaryZoneId")]
        [Validation(Required=false)]
        public string ExcludeSecondaryZoneId { get; set; }

        /// <summary>
        /// <para>The zone ID to be excluded from the query results in the current region.</para>
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
        /// <item><description><b>PrePaid</b>: subscription. Default value.</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>sharding</b>: sharded cluster instance.</description></item>
        /// <item><description><b>replicate</b>: replica set instance or standalone instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>replicate</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The MongoDB edition, such as the high-availability edition or the test edition (dbfs).</para>
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
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of nodes.</para>
        /// <remarks>
        /// <para>This parameter is supported only for replica set instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ReplicationFactor")]
        [Validation(Required=false)]
        public string ReplicationFactor { get; set; }

        /// <summary>
        /// <para>The resource group ID. For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/151181.html">View the basic information of a resource group</a>.</para>
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
        /// <para>The storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud</b>: displays only the zones that support cloud disk instances.</description></item>
        /// <item><description><b>local</b>: displays only the zones that support local disk instances.</description></item>
        /// <item><description><b>default</b> or empty: displays the zones that support both local disk and cloud disk instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>local</para>
        /// </summary>
        [NameInMap("StorageSupport")]
        [Validation(Required=false)]
        public string StorageSupport { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>cloud_essd1</b>: PL1 ESSD.</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD.</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD.</description></item>
        /// <item><description><b>local_ssd</b>: local SSD.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Instances of version 4.4 and later support only cloud disks. If you do not specify this parameter, <b>cloud_essd1</b> is selected by default.</description></item>
        /// <item><description>Instances of version 4.2 and earlier support only local disks. If you do not specify this parameter, <b>local_ssd</b> is selected by default.</description></item>
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
        /// <para>The zone ID. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
