// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBMiniEngineVersionsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the ID.</para>
        /// <remarks>
        /// <para>For ApsaraDB RDS for PostgreSQL instances, if you specify an instance ID, only minor versions later than the current minor version of the instance are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The dedicated cluster ID. You can call the DescribeDedicatedHostGroups operation to query the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-4n****</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>The database engine. Set the value to <b>MySQL</b> or <b>PostgreSQL</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database engine version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MySQL: <b>8.0</b>, <b>5.7</b>, <b>5.6</b>, <b>5.5</b></description></item>
        /// <item><description>PostgreSQL: <b>17.0</b>, <b>16.0</b>, <b>15.0</b>, <b>14.0</b>, <b>13.0</b>, <b>12.0</b>, <b>11.0</b>, <b>10.0</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5.7</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The minor engine version number. Specify this parameter to query the details of the specified minor version.</para>
        /// <remarks>
        /// <para>This parameter is applicable only to ApsaraDB RDS for MySQL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rds_20220731</para>
        /// </summary>
        [NameInMap("MinorVersionTag")]
        [Validation(Required=false)]
        public string MinorVersionTag { get; set; }

        /// <summary>
        /// <para>The instance edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: Basic Edition.</description></item>
        /// <item><description><b>HighAvailability</b>: high-availability series.</description></item>
        /// <item><description><b>cluster</b>: Cluster Edition.</description></item>
        /// <item><description><b>Finance</b>: RDS Enterprise Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HighAvailability</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The instance storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>local_ssd</b>: Premium Local SSDs.</description></item>
        /// <item><description><b>general_essd</b>: premium performance disk.</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSDs.</description></item>
        /// <item><description><b>cloud_essd</b>: PL1 ESSDs.</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSDs.</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSDs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
