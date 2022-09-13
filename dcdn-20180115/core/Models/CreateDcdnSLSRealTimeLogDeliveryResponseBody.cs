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
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
