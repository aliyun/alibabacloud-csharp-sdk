// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ReplaceCloudGtmAddressPoolAddressRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("AddressPoolId")]
        [Validation(Required=false)]
        public string AddressPoolId { get; set; }

        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<ReplaceCloudGtmAddressPoolAddressRequestAddresses> Addresses { get; set; }
        public class ReplaceCloudGtmAddressPoolAddressRequestAddresses : TeaModel {
            [NameInMap("AddressId")]
            [Validation(Required=false)]
            public string AddressId { get; set; }

            [NameInMap("RequestSource")]
            [Validation(Required=false)]
            public List<string> RequestSource { get; set; }

            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public int? SerialNumber { get; set; }

            [NameInMap("WeightValue")]
            [Validation(Required=false)]
            public int? WeightValue { get; set; }

        }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
