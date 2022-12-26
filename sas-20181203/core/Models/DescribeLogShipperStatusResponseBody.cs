// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLogShipperStatusResponseBody : TeaModel {
        [NameInMap("LogShipperStatus")]
        [Validation(Required=false)]
        public DescribeLogShipperStatusResponseBodyLogShipperStatus LogShipperStatus { get; set; }
        public class DescribeLogShipperStatusResponseBodyLogShipperStatus : TeaModel {
            [NameInMap("AuthStatus")]
            [Validation(Required=false)]
            public string AuthStatus { get; set; }

            [NameInMap("BuyStatus")]
            [Validation(Required=false)]
            public string BuyStatus { get; set; }

            [NameInMap("OpenStatus")]
            [Validation(Required=false)]
            public string OpenStatus { get; set; }

            [NameInMap("PostPaidOpenStatus")]
            [Validation(Required=false)]
            public string PostPaidOpenStatus { get; set; }

            [NameInMap("PostPaidSupportStatus")]
            [Validation(Required=false)]
            public string PostPaidSupportStatus { get; set; }

            [NameInMap("SlsProjectStatus")]
            [Validation(Required=false)]
            public string SlsProjectStatus { get; set; }

            [NameInMap("SlsServiceStatus")]
            [Validation(Required=false)]
            public string SlsServiceStatus { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
