// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class SubmitIsvCustomerTermsRequest : TeaModel {
        [NameInMap("BusinessDesc")]
        [Validation(Required=false)]
        public string BusinessDesc { get; set; }

        [NameInMap("ContactMail")]
        [Validation(Required=false)]
        public string ContactMail { get; set; }

        [NameInMap("CountryId")]
        [Validation(Required=false)]
        public string CountryId { get; set; }

        [NameInMap("CustName")]
        [Validation(Required=false)]
        public string CustName { get; set; }

        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        [NameInMap("IsvTerms")]
        [Validation(Required=false)]
        public string IsvTerms { get; set; }

        [NameInMap("OfficeAddress")]
        [Validation(Required=false)]
        public string OfficeAddress { get; set; }

    }

}
