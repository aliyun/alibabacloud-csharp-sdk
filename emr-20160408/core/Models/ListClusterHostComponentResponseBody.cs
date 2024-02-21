// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListClusterHostComponentResponseBody : TeaModel {
        [NameInMap("ComponentList")]
        [Validation(Required=false)]
        public ListClusterHostComponentResponseBodyComponentList ComponentList { get; set; }
        public class ListClusterHostComponentResponseBodyComponentList : TeaModel {
            [NameInMap("Component")]
            [Validation(Required=false)]
            public List<ListClusterHostComponentResponseBodyComponentListComponent> Component { get; set; }
            public class ListClusterHostComponentResponseBodyComponentListComponent : TeaModel {
                [NameInMap("CommissionStatus")]
                [Validation(Required=false)]
                public string CommissionStatus { get; set; }

                [NameInMap("ComponentDisplayName")]
                [Validation(Required=false)]
                public string ComponentDisplayName { get; set; }

                [NameInMap("ComponentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                [NameInMap("HealthReportTime")]
                [Validation(Required=false)]
                public long? HealthReportTime { get; set; }

                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                [NameInMap("HostId")]
                [Validation(Required=false)]
                public string HostId { get; set; }

                [NameInMap("HostInstanceId")]
                [Validation(Required=false)]
                public string HostInstanceId { get; set; }

                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                [NameInMap("NeedRestart")]
                [Validation(Required=false)]
                public bool? NeedRestart { get; set; }

                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }

                [NameInMap("PublicIp")]
                [Validation(Required=false)]
                public string PublicIp { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                [NameInMap("ServerStatus")]
                [Validation(Required=false)]
                public string ServerStatus { get; set; }

                [NameInMap("ServiceDisplayName")]
                [Validation(Required=false)]
                public string ServiceDisplayName { get; set; }

                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

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
