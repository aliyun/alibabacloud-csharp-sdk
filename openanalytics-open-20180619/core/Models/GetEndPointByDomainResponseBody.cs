// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class GetEndPointByDomainResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("EndPointInfo")]
        [Validation(Required=false)]
        public GetEndPointByDomainResponseBodyEndPointInfo EndPointInfo { get; set; }
        public class GetEndPointByDomainResponseBodyEndPointInfo : TeaModel {
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }
            [NameInMap("cloudInstanceID")]
            [Validation(Required=false)]
            public string CloudInstanceID { get; set; }
            [NameInMap("zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }
            [NameInMap("domainURL")]
            [Validation(Required=false)]
            public string DomainURL { get; set; }
            [NameInMap("vSwitch")]
            [Validation(Required=false)]
            public string VSwitch { get; set; }
            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }
            [NameInMap("allowIP")]
            [Validation(Required=false)]
            public string AllowIP { get; set; }
            [NameInMap("vpcID")]
            [Validation(Required=false)]
            public string VpcID { get; set; }
            [NameInMap("endPointID")]
            [Validation(Required=false)]
            public string EndPointID { get; set; }
            [NameInMap("networkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }
            [NameInMap("port")]
            [Validation(Required=false)]
            public string Port { get; set; }
        };

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
