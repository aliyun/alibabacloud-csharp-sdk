// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateWhiteIpsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateWhiteIpsResponseBodyResult Result { get; set; }
        public class UpdateWhiteIpsResponseBodyResult : TeaModel {
            [NameInMap("esIPWhitelist")]
            [Validation(Required=false)]
            public List<string> EsIPWhitelist { get; set; }
            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public UpdateWhiteIpsResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class UpdateWhiteIpsResponseBodyResultNetworkConfig : TeaModel {
                [NameInMap("whiteIpGroupList")]
                [Validation(Required=false)]
                public List<UpdateWhiteIpsResponseBodyResultNetworkConfigWhiteIpGroupList> WhiteIpGroupList { get; set; }
                public class UpdateWhiteIpsResponseBodyResultNetworkConfigWhiteIpGroupList : TeaModel {
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
        };

    }

}
