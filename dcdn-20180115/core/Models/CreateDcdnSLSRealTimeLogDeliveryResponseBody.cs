// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateDcdnSLSRealTimeLogDeliveryResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public CreateDcdnSLSRealTimeLogDeliveryResponseBodyContent Content { get; set; }
        public class CreateDcdnSLSRealTimeLogDeliveryResponseBodyContent : TeaModel {
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<CreateDcdnSLSRealTimeLogDeliveryResponseBodyContentDomains> Domains { get; set; }
            public class CreateDcdnSLSRealTimeLogDeliveryResponseBodyContentDomains : TeaModel {
                public string Desc { get; set; }
                public string DomainName { get; set; }
                public string Region { get; set; }
                public string Status { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
