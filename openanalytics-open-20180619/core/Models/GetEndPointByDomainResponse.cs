// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class GetEndPointByDomainResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("EndPointInfo")]
        [Validation(Required=true)]
        public GetEndPointByDomainResponseEndPointInfo EndPointInfo { get; set; }
        public class GetEndPointByDomainResponseEndPointInfo : TeaModel {
            [NameInMap("endPointID")]
            [Validation(Required=true)]
            public string EndPointID { get; set; }
            [NameInMap("domainURL")]
            [Validation(Required=true)]
            public string DomainURL { get; set; }
            [NameInMap("host")]
            [Validation(Required=true)]
            public string Host { get; set; }
            [NameInMap("port")]
            [Validation(Required=true)]
            public string Port { get; set; }
            [NameInMap("networkType")]
            [Validation(Required=true)]
            public string NetworkType { get; set; }
            [NameInMap("vpcID")]
            [Validation(Required=true)]
            public string VpcID { get; set; }
            [NameInMap("vSwitch")]
            [Validation(Required=true)]
            public string VSwitch { get; set; }
            [NameInMap("zone")]
            [Validation(Required=true)]
            public string Zone { get; set; }
            [NameInMap("allowIP")]
            [Validation(Required=true)]
            public string AllowIP { get; set; }
            [NameInMap("cloudInstanceID")]
            [Validation(Required=true)]
            public string CloudInstanceID { get; set; }
            [NameInMap("product")]
            [Validation(Required=true)]
            public string Product { get; set; }
        };

    }

}
