// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class CreateDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>The reserved cache size.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("CacheSize")]
        [Validation(Required=false)]
        public string CacheSize { get; set; }

        /// <summary>
        /// <para>The billing method of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Postpaid</b>: pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para><b>Prepaid</b>: subscription.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("ClusterNodeCount")]
        [Validation(Required=false)]
        public int? ClusterNodeCount { get; set; }

        [NameInMap("ClusterNodeType")]
        [Validation(Required=false)]
        public string ClusterNodeType { get; set; }

        /// <summary>
        /// <para>The instance type of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>selectdb.xlarge</b>: 4 cores, 32 GB.</para>
        /// </description></item>
        /// <item><description><para><b>selectdb.2xlarge</b>: 8 cores, 64 GB.</para>
        /// </description></item>
        /// <item><description><para><b>selectdb.4xlarge</b>: 16 cores, 128 GB.</para>
        /// </description></item>
        /// <item><description><para><b>selectdb.8xlarge</b>: 32 cores, 256 GB.</para>
        /// </description></item>
        /// <item><description><para><b>selectdb.16xlarge</b>: 64 cores, 512 GB.</para>
        /// </description></item>
        /// <item><description><para><b>selectdb.24xlarge</b>: 96 cores, 768 GB.</para>
        /// </description></item>
        /// <item><description><para><b>selectdb.32xlarge</b>: 128 cores, 1024 GB.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb.2xlarge</para>
        /// </summary>
        [NameInMap("DBClusterClass")]
        [Validation(Required=false)]
        public string DBClusterClass { get; set; }

        /// <summary>
        /// <para>The description of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-cn-7213cjv****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The database engine type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database engine version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.4</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The billing cycle of the subscription cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Year</b>: The cluster is billed on a yearly basis.</para>
        /// </description></item>
        /// <item><description><para><b>Month</b>: The cluster is billed on a monthly basis.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required and takes effect only when <b>ChargeType</b> is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
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

        [NameInMap("ScaleMax")]
        [Validation(Required=false)]
        public double? ScaleMax { get; set; }

        [NameInMap("ScaleMin")]
        [Validation(Required=false)]
        public double? ScaleMin { get; set; }

        /// <summary>
        /// <para>The subscription duration of the subscription cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If Period is set to Year, valid values for UsedTime are 1, 2, 3, and 5.</para>
        /// </description></item>
        /// <item><description><para>If Period is set to Month, the value of UsedTime can be an integer from 1 to 9.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required and takes effect only when ChargeType is set to Prepaid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1gzt31twhlo0sa5****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp175iuvg8nxqraf2****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
