// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AllocateEipAddressResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("BizStatusCode")]
        [Validation(Required=true)]
        public string BizStatusCode { get; set; }

        [NameInMap("EipAddresses")]
        [Validation(Required=true)]
        public AllocateEipAddressResponseEipAddresses EipAddresses { get; set; }
        public class AllocateEipAddressResponseEipAddresses : TeaModel {
            [NameInMap("EipAddress")]
            [Validation(Required=true)]
            public List<AllocateEipAddressResponseEipAddressesEipAddress> EipAddress { get; set; }
            public class AllocateEipAddressResponseEipAddressesEipAddress : TeaModel {
                public string Eip { get; set; }
            }
        };

    }

}
