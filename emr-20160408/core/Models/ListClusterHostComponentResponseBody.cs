// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListClusterHostComponentResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("ComponentList")]
        [Validation(Required=false)]
        public ListClusterHostComponentResponseBodyComponentList ComponentList { get; set; }
        public class ListClusterHostComponentResponseBodyComponentList : TeaModel {
            [NameInMap("Component")]
            [Validation(Required=false)]
            public List<ListClusterHostComponentResponseBodyComponentListComponent> Component { get; set; }
            public class ListClusterHostComponentResponseBodyComponentListComponent : TeaModel {
                public string ServiceDisplayName { get; set; }
                public string Status { get; set; }
                public string SerialNumber { get; set; }
                public string ServerStatus { get; set; }
                public string PrivateIp { get; set; }
                public string ComponentName { get; set; }
                public string CommissionStatus { get; set; }
                public string HostName { get; set; }
                public bool? NeedRestart { get; set; }
                public string InstanceType { get; set; }
                public string HostId { get; set; }
                public string HostInstanceId { get; set; }
                public int? Cpu { get; set; }
                public string ComponentDisplayName { get; set; }
                public string PublicIp { get; set; }
                public int? Memory { get; set; }
                public string Role { get; set; }
                public string ServiceName { get; set; }
            }
        };

    }

}
