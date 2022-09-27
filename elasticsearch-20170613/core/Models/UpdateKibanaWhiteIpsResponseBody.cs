// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateKibanaWhiteIpsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateKibanaWhiteIpsResponseBodyResult Result { get; set; }
        public class UpdateKibanaWhiteIpsResponseBodyResult : TeaModel {
            [NameInMap("kibanaIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaIPWhitelist { get; set; }

            [NameInMap("kibanaPrivateIPWhitelist")]
            [Validation(Required=false)]
            public List<string> KibanaPrivateIPWhitelist { get; set; }

            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public UpdateKibanaWhiteIpsResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class UpdateKibanaWhiteIpsResponseBodyResultNetworkConfig : TeaModel {
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("vsArea")]
                [Validation(Required=false)]
                public string VsArea { get; set; }

                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                [NameInMap("whiteIpGroupList")]
                [Validation(Required=false)]
                public List<UpdateKibanaWhiteIpsResponseBodyResultNetworkConfigWhiteIpGroupList> WhiteIpGroupList { get; set; }
                public class UpdateKibanaWhiteIpsResponseBodyResultNetworkConfigWhiteIpGroupList : TeaModel {
                    [NameInMap("groupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    [NameInMap("ips")]
                    [Validation(Required=false)]
                    public List<string> Ips { get; set; }

                    [NameInMap("whiteIpType")]
                    [Validation(Required=false)]
                    public string WhiteIpType { get; set; }

                }

            }

        }

    }

}
