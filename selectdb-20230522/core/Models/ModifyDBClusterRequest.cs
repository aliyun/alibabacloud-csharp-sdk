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

        [NameInMap("ClusterNodeCount")]
        [Validation(Required=false)]
        public int? ClusterNodeCount { get; set; }

        [NameInMap("ClusterNodeType")]
        [Validation(Required=false)]
        public string ClusterNodeType { get; set; }

        /// <summary>
        /// <para>The cluster specifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>selectdb.xlarge</b>: 4 cores, 32 GB memory.</description></item>
        /// <item><description><b>selectdb.2xlarge</b>: 8 cores, 64 GB memory.</description></item>
        /// <item><description><b>selectdb.4xlarge</b>: 16 cores, 128 GB memory.</description></item>
        /// <item><description><b>selectdb.8xlarge</b>: 32 cores, 256 GB memory.</description></item>
        /// <item><description><b>selectdb.16xlarge</b>: 16 cores, 512 GB memory.</description></item>
        /// <item><description><b>selectdb.24xlarge</b>: 24 cores, 768 GB memory.</description></item>
        /// <item><description><b>selectdb.32xlarge</b>: 32 cores, 1024 GB memory.</description></item>
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
        /// <para>The database type. Set the value to selectdb.</para>
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

        [NameInMap("ScaleMax")]
        [Validation(Required=false)]
        public double? ScaleMax { get; set; }

        [NameInMap("ScaleMin")]
        [Validation(Required=false)]
        public double? ScaleMin { get; set; }

    }

}
