// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class CombineWTSRequest : TeaModel {
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("Contact")]
        [Validation(Required=false)]
        public string Contact { get; set; }

        [NameInMap("ContactAddressPost")]
        [Validation(Required=false)]
        public string ContactAddressPost { get; set; }

        [NameInMap("ContactMobile")]
        [Validation(Required=false)]
        public string ContactMobile { get; set; }

        [NameInMap("MaterialId")]
        [Validation(Required=false)]
        public string MaterialId { get; set; }

        [NameInMap("MaterialName")]
        [Validation(Required=false)]
        public string MaterialName { get; set; }

        [NameInMap("Nationality")]
        [Validation(Required=false)]
        public string Nationality { get; set; }

        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public string PrincipalName { get; set; }

        [NameInMap("TmNum")]
        [Validation(Required=false)]
        public string TmNum { get; set; }

        [NameInMap("TmProduceType")]
        [Validation(Required=false)]
        public string TmProduceType { get; set; }

        [NameInMap("TrademarkName")]
        [Validation(Required=false)]
        public string TrademarkName { get; set; }

        [NameInMap("WtsType")]
        [Validation(Required=false)]
        public string WtsType { get; set; }

    }

}
