// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class DescribeHttpTriggerConfigResponseBody : TeaModel {
        [NameInMap("EnableService")]
        [Validation(Required=false)]
        public bool? EnableService { get; set; }

        [NameInMap("CustomDomainCname")]
        [Validation(Required=false)]
        public string CustomDomainCname { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DefaultEndpoint")]
        [Validation(Required=false)]
        public string DefaultEndpoint { get; set; }

        [NameInMap("CustomDomainCertificateInfo")]
        [Validation(Required=false)]
        public string CustomDomainCertificateInfo { get; set; }

        [NameInMap("CustomDomain")]
        [Validation(Required=false)]
        public string CustomDomain { get; set; }

    }

}
