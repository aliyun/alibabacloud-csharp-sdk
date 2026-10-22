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
        /// <item><description><para><b>Postpaid</b>: pay-as-you-go</para>
        /// </description></item>
        /// <item><description><para><b>Prepaid</b>: subscription</para>
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

        /// <summary>
        /// <para>The number of nodes in the cluster. This parameter takes effect only in Serverless mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ClusterNodeCount")]
        [Validation(Required=false)]
        public int? ClusterNodeCount { get; set; }

        /// <summary>
        /// <para>The node type of the cluster. This parameter takes effect only in Serverless mode.</para>
        /// </summary>
        [NameInMap("ClusterNodeType")]
        [Validation(Required=false)]
        public string ClusterNodeType { get; set; }

        /// <summary>
        /// <para>The cluster specifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>selectdb.xlarge</b>: 4 cores and 32 GB memory</description></item>
        /// <item><description><b>selectdb.2xlarge</b>: 8 cores and 64 GB memory</description></item>
        /// <item><description><b>selectdb.4xlarge</b>: 16 cores and 128 GB memory</description></item>
        /// <item><description><b>selectdb.8xlarge</b>: 32 cores and 256 GB memory</description></item>
        /// <item><description><b>selectdb.16xlarge</b>: 64 cores and 512 GB memory</description></item>
        /// <item><description><b>selectdb.24xlarge</b>: 96 cores and 768 GB memory</description></item>
        /// <item><description><b>selectdb.32xlarge</b>: 128 cores and 1024 GB memory</description></item>
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
        /// <para>The cluster description.</para>
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
        /// <para>The database type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.4</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether the subscription cluster is billed on a yearly or monthly basis. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: yearly</description></item>
        /// <item><description><b>Month</b>: monthly<remarks>
        /// <para>This parameter takes effect and is required only when <b>ChargeType</b> is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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

        /// <summary>
        /// <para>The maximum value of the auto-scaling range for the instance RCU (RDS Capacity Unit).</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("ScaleMax")]
        [Validation(Required=false)]
        public double? ScaleMax { get; set; }

        /// <summary>
        /// <para>The minimum value of the auto-scaling range for the instance RCU (RDS Capacity Unit).</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ScaleMin")]
        [Validation(Required=false)]
        public double? ScaleMin { get; set; }

        /// <summary>
        /// <para>Specifies the purchase duration of the subscription cluster. The unit is specified by Period: Year indicates years, and Month indicates months. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If Period is set to Year, valid values for UsedTime are 1, 2, 3, and 5.</description></item>
        /// <item><description>If Period is set to Month, valid values for UsedTime are 1 to 9.<remarks>
        /// <para>This parameter takes effect and is required only when ChargeType is set to Prepaid.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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
