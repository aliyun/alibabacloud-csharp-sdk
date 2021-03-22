// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20180117.Models
{
    public class ModifyDomainConfigRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("SourceIps")]
        [Validation(Required=false)]
        public string SourceIps { get; set; }

        [NameInMap("HttpPort")]
        [Validation(Required=false)]
        public string HttpPort { get; set; }

        [NameInMap("HttpsPort")]
        [Validation(Required=false)]
        public string HttpsPort { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("IsAccessProduct")]
        [Validation(Required=false)]
        public int? IsAccessProduct { get; set; }

        [NameInMap("Protocols")]
        [Validation(Required=false)]
        public string Protocols { get; set; }

        [NameInMap("LoadBalancing")]
        [Validation(Required=false)]
        public int? LoadBalancing { get; set; }

        [NameInMap("HttpToUserIp")]
        [Validation(Required=false)]
        public int? HttpToUserIp { get; set; }

        [NameInMap("HttpsRedirect")]
        [Validation(Required=false)]
        public int? HttpsRedirect { get; set; }

    }

}
