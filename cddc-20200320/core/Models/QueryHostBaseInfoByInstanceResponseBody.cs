// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class QueryHostBaseInfoByInstanceResponseBody : TeaModel {
        [NameInMap("HostInstanceConsoleInfos")]
        [Validation(Required=false)]
        public List<QueryHostBaseInfoByInstanceResponseBodyHostInstanceConsoleInfos> HostInstanceConsoleInfos { get; set; }
        public class QueryHostBaseInfoByInstanceResponseBodyHostInstanceConsoleInfos : TeaModel {
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
