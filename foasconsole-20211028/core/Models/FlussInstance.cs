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

        [NameInMap("ClusterStatus")]
        [Validation(Required=false)]
        public string ClusterStatus { get; set; }

        [NameInMap("ConsoleUrl")]
        [Validation(Required=false)]
        public string ConsoleUrl { get; set; }

        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public long? DiskSize { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("OrderState")]
        [Validation(Required=false)]
        public string OrderState { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceCreateTime")]
        [Validation(Required=false)]
        public long? ResourceCreateTime { get; set; }

        [NameInMap("ResourceExpiredTime")]
        [Validation(Required=false)]
        public long? ResourceExpiredTime { get; set; }

        [NameInMap("TabletServerModel")]
        [Validation(Required=false)]
        public string TabletServerModel { get; set; }

        [NameInMap("TabletServerNum")]
        [Validation(Required=false)]
        public long? TabletServerNum { get; set; }

        [NameInMap("TabletServerType")]
        [Validation(Required=false)]
        public string TabletServerType { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public List<FlussVswitch> VSwitches { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
