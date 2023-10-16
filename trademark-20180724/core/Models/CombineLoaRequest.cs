// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class CombineLoaRequest : TeaModel {
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("ApplicantType")]
        [Validation(Required=false)]
        public string ApplicantType { get; set; }

        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        [NameInMap("ContactPhone")]
        [Validation(Required=false)]
        public string ContactPhone { get; set; }

        [NameInMap("ContactPostcode")]
        [Validation(Required=false)]
        public string ContactPostcode { get; set; }

        [NameInMap("MaterialId")]
        [Validation(Required=false)]
        public string MaterialId { get; set; }

        [NameInMap("MaterialName")]
        [Validation(Required=false)]
        public string MaterialName { get; set; }

        [NameInMap("Nationality")]
        [Validation(Required=false)]
        public string Nationality { get; set; }

        [NameInMap("PersonalType")]
        [Validation(Required=false)]
        public string PersonalType { get; set; }

        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public int? PrincipalName { get; set; }

        [NameInMap("TmNumber")]
        [Validation(Required=false)]
        public string TmNumber { get; set; }

        [NameInMap("TmProduceType")]
        [Validation(Required=false)]
        public string TmProduceType { get; set; }

        [NameInMap("TrademarkName")]
        [Validation(Required=false)]
        public string TrademarkName { get; set; }

    }

}
