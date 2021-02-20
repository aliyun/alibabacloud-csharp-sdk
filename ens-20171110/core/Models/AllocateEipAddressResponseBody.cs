// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AllocateEipAddressResponseBody : TeaModel {
        [NameInMap("BizStatusCode")]
        [Validation(Required=false)]
        public string BizStatusCode { get; set; }

        [NameInMap("EipAddresses")]
        [Validation(Required=false)]
        public AllocateEipAddressResponseBodyEipAddresses EipAddresses { get; set; }
        public class AllocateEipAddressResponseBodyEipAddresses : TeaModel {
            [NameInMap("EipAddress")]
            [Validation(Required=false)]
            public List<AllocateEipAddressResponseBodyEipAddressesEipAddress> EipAddress { get; set; }
            public class AllocateEipAddressResponseBodyEipAddressesEipAddress : TeaModel {
                public string Eip { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
