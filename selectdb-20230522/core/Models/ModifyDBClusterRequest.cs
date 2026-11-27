// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class ModifyDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>The reserved cache size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("CacheSize")]
        [Validation(Required=false)]
        public string CacheSize { get; set; }

        /// <summary>
        /// <para>The number of cluster nodes. This parameter takes effect only in Serverless mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ClusterNodeCount")]
        [Validation(Required=false)]
        public int? ClusterNodeCount { get; set; }

        /// <summary>
        /// <para>The cluster node type. This parameter takes effect only in Serverless mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base</para>
        /// </summary>
        [NameInMap("ClusterNodeType")]
        [Validation(Required=false)]
        public string ClusterNodeType { get; set; }

        /// <summary>
        /// <para>The cluster specifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>selectdb.g.xlarge</b>: 4 vCPUs and 16 GB of memory.</description></item>
        /// <item><description><b>selectdb.g.2xlarge</b>: 8 vCPUs and 32 GB of memory.</description></item>
        /// <item><description><b>selectdb.g.4xlarge</b>: 16 vCPUs and 64 GB of memory.</description></item>
        /// <item><description><b>selectdb.g.8xlarge</b>: 32 vCPUs and 128 GB of memory.</description></item>
        /// <item><description><b>selectdb.g.16xlarge</b>: 64 vCPUs and 256 GB of memory.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb.g.2xlarge</para>
        /// </summary>
        [NameInMap("DBClusterClass")]
        [Validation(Required=false)]
        public string DBClusterClass { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb-xxxb9f2w-be</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

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
        /// <para>The database engine type. Set the value to selectdb.</para>
        /// 
        /// <b>Example:</b>
        /// <para>selectdb</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

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
        /// <para>The maximum value of the auto-scaling range for instance RCUs (RDS Capacity Units).</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("ScaleMax")]
        [Validation(Required=false)]
        public double? ScaleMax { get; set; }

        /// <summary>
        /// <para>The minimum value of the auto-scaling range for instance RCUs (RDS Capacity Units).</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("ScaleMin")]
        [Validation(Required=false)]
        public double? ScaleMin { get; set; }

    }

}
