// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListTrafficControlTasksRequest : TeaModel {
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        [NameInMap("ControlTargetFilter")]
        [Validation(Required=false)]
        public string ControlTargetFilter { get; set; }

        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TrafficControlTaskId")]
        [Validation(Required=false)]
        public string TrafficControlTaskId { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
