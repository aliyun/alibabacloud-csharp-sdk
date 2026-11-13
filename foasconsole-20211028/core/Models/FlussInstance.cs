// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class FlussInstance : TeaModel {
        /// <summary>
        /// <para>The running state information of the cluster.</para>
        /// </summary>
        [NameInMap("ClusterState")]
        [Validation(Required=false)]
        public ClusterState ClusterState { get; set; }

        /// <summary>
        /// <para>The status of the Fluss cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("ClusterStatus")]
        [Validation(Required=false)]
        public string ClusterStatus { get; set; }

        /// <summary>
        /// <para>The console access URL of the Fluss instance.</para>
        /// </summary>
        [NameInMap("ConsoleUrl")]
        [Validation(Required=false)]
        public string ConsoleUrl { get; set; }

        /// <summary>
        /// <para>The disk size of a single TabletServer node, in GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public long? DiskSize { get; set; }

        /// <summary>
        /// <para>Specifies whether multi-zone high availability is enabled.</para>
        /// </summary>
        [NameInMap("Ha")]
        [Validation(Required=false)]
        public bool? Ha { get; set; }

        /// <summary>
        /// <para>The ID of the Fluss instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f-cn-zvp2q0z****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the Fluss instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fluss-test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The order status of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("OrderState")]
        [Validation(Required=false)]
        public string OrderState { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The creation time of the instance, represented as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1629879567394</para>
        /// </summary>
        [NameInMap("ResourceCreateTime")]
        [Validation(Required=false)]
        public long? ResourceCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the instance expires, represented as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1637337600000</para>
        /// </summary>
        [NameInMap("ResourceExpiredTime")]
        [Validation(Required=false)]
        public long? ResourceExpiredTime { get; set; }

        /// <summary>
        /// <para>The TabletServer node specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4 RCU</para>
        /// </summary>
        [NameInMap("TabletServerModel")]
        [Validation(Required=false)]
        public string TabletServerModel { get; set; }

        /// <summary>
        /// <para>The number of TabletServer nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TabletServerNum")]
        [Validation(Required=false)]
        public long? TabletServerNum { get; set; }

        /// <summary>
        /// <para>The type of TabletServer node specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4 RCU</para>
        /// </summary>
        [NameInMap("TabletServerType")]
        [Validation(Required=false)]
        public string TabletServerType { get; set; }

        /// <summary>
        /// <para>The upper limit of elastic compute resources for the lake-stream synchronization service, in CUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TieringPostCu")]
        [Validation(Required=false)]
        public long? TieringPostCu { get; set; }

        /// <summary>
        /// <para>The base compute resource count for the lake-stream synchronization service, in CUs.</para>
        /// </summary>
        [NameInMap("TieringPreCu")]
        [Validation(Required=false)]
        public long? TieringPreCu { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>183899668736****</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

        /// <summary>
        /// <para>The list of zone and vSwitch configurations used by the instance.</para>
        /// </summary>
        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public List<FlussVswitch> VSwitches { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2ze9*******nxfmfcdi</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
