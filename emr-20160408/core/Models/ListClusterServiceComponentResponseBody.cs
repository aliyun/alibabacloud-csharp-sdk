// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListClusterServiceComponentResponseBody : TeaModel {
        [NameInMap("ComponentList")]
        [Validation(Required=false)]
        public ListClusterServiceComponentResponseBodyComponentList ComponentList { get; set; }
        public class ListClusterServiceComponentResponseBodyComponentList : TeaModel {
            [NameInMap("Component")]
            [Validation(Required=false)]
            public List<ListClusterServiceComponentResponseBodyComponentListComponent> Component { get; set; }
            public class ListClusterServiceComponentResponseBodyComponentListComponent : TeaModel {
                public string CommissionStatus { get; set; }
                public string ComponentDisplayName { get; set; }
                public string ComponentName { get; set; }
                public int? DesiredCount { get; set; }
                public string Namespace { get; set; }
                public bool? NeedRestart { get; set; }
                public string PodName { get; set; }
                public string PrivateIp { get; set; }
                public string PublicIp { get; set; }
                public string Role { get; set; }
                public string ServerStatus { get; set; }
                public string ServiceDisplayName { get; set; }
                public string ServiceName { get; set; }
                public string Status { get; set; }
                public string WorkloadName { get; set; }
                public string WorkloadType { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
