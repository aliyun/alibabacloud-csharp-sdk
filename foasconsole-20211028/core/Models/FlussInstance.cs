// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class FlussInstance : TeaModel {
        [NameInMap("ClusterState")]
        [Validation(Required=false)]
        public ClusterState ClusterState { get; set; }

        /// <summary>
        /// <para>The cluster status.</para>
        /// </summary>
        [NameInMap("ClusterStatus")]
        [Validation(Required=false)]
        public string ClusterStatus { get; set; }

        /// <summary>
        /// <para>The URL of the instance management console.</para>
        /// </summary>
        [NameInMap("ConsoleUrl")]
        [Validation(Required=false)]
        public string ConsoleUrl { get; set; }

        /// <summary>
        /// <para>The disk size, in GB.</para>
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public long? DiskSize { get; set; }

        /// <summary>
        /// <para>Specifies whether high availability (HA) is enabled.</para>
        /// </summary>
        [NameInMap("Ha")]
        [Validation(Required=false)]
        public bool? Ha { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The order state.</para>
        /// </summary>
        [NameInMap("OrderState")]
        [Validation(Required=false)]
        public string OrderState { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The creation time of the resource, as a UNIX timestamp in milliseconds.</para>
        /// </summary>
        [NameInMap("ResourceCreateTime")]
        [Validation(Required=false)]
        public long? ResourceCreateTime { get; set; }

        /// <summary>
        /// <para>The expiration time of the resource, as a UNIX timestamp in milliseconds.</para>
        /// </summary>
        [NameInMap("ResourceExpiredTime")]
        [Validation(Required=false)]
        public long? ResourceExpiredTime { get; set; }

        /// <summary>
        /// <para>The tablet server model.</para>
        /// </summary>
        [NameInMap("TabletServerModel")]
        [Validation(Required=false)]
        public string TabletServerModel { get; set; }

        /// <summary>
        /// <para>The number of tablet servers.</para>
        /// </summary>
        [NameInMap("TabletServerNum")]
        [Validation(Required=false)]
        public long? TabletServerNum { get; set; }

        /// <summary>
        /// <para>The tablet server type.</para>
        /// </summary>
        [NameInMap("TabletServerType")]
        [Validation(Required=false)]
        public string TabletServerType { get; set; }

        /// <summary>
        /// <para>The number of compute units (CUs) for post-tiering.</para>
        /// </summary>
        [NameInMap("TieringPostCu")]
        [Validation(Required=false)]
        public long? TieringPostCu { get; set; }

        /// <summary>
        /// <para>The number of compute units (CUs) for pre-tiering.</para>
        /// </summary>
        [NameInMap("TieringPreCu")]
        [Validation(Required=false)]
        public long? TieringPreCu { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID (UID).</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

        /// <summary>
        /// <para>The VSwitch details.</para>
        /// </summary>
        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public List<FlussVswitch> VSwitches { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
