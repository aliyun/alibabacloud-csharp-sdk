// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160201.Models
{
    public class VpcQueryAppServersResponseBody : TeaModel {
        [NameInMap("AppServerInfos")]
        [Validation(Required=false)]
        public VpcQueryAppServersResponseBodyAppServerInfos AppServerInfos { get; set; }
        public class VpcQueryAppServersResponseBodyAppServerInfos : TeaModel {
            [NameInMap("AppServerInfo")]
            [Validation(Required=false)]
            public List<VpcQueryAppServersResponseBodyAppServerInfosAppServerInfo> AppServerInfo { get; set; }
            public class VpcQueryAppServersResponseBodyAppServerInfosAppServerInfo : TeaModel {
                [NameInMap("AddressPoolId")]
                [Validation(Required=false)]
                public string AddressPoolId { get; set; }

                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("ServerIp")]
                [Validation(Required=false)]
                public string ServerIp { get; set; }

                [NameInMap("ServerMappingIp")]
                [Validation(Required=false)]
                public string ServerMappingIp { get; set; }

                [NameInMap("ServerType")]
                [Validation(Required=false)]
                public string ServerType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
