// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class RunClusterServiceActionRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("ComponentNameList")]
        [Validation(Required=false)]
        public string ComponentNameList { get; set; }

        [NameInMap("CustomCommand")]
        [Validation(Required=false)]
        public string CustomCommand { get; set; }

        [NameInMap("CustomParams")]
        [Validation(Required=false)]
        public string CustomParams { get; set; }

        [NameInMap("ExecuteStrategy")]
        [Validation(Required=false)]
        public string ExecuteStrategy { get; set; }

        [NameInMap("HostGroupIdList")]
        [Validation(Required=false)]
        public List<string> HostGroupIdList { get; set; }

        [NameInMap("HostIdList")]
        [Validation(Required=false)]
        public string HostIdList { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        [NameInMap("IsRolling")]
        [Validation(Required=false)]
        public bool? IsRolling { get; set; }

        [NameInMap("NodeCountPerBatch")]
        [Validation(Required=false)]
        public int? NodeCountPerBatch { get; set; }

        [NameInMap("OnlyRestartStaleConfigNodes")]
        [Validation(Required=false)]
        public bool? OnlyRestartStaleConfigNodes { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("ServiceActionName")]
        [Validation(Required=false)]
        public string ServiceActionName { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("TotlerateFailCount")]
        [Validation(Required=false)]
        public int? TotlerateFailCount { get; set; }

        [NameInMap("TurnOnMaintenanceMode")]
        [Validation(Required=false)]
        public bool? TurnOnMaintenanceMode { get; set; }

    }

}
