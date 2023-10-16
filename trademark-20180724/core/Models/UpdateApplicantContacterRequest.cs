// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class UpdateApplicantContacterRequest : TeaModel {
        [NameInMap("ApplicantId")]
        [Validation(Required=false)]
        public long? ApplicantId { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("ContactAddress")]
        [Validation(Required=false)]
        public string ContactAddress { get; set; }

        [NameInMap("ContactCity")]
        [Validation(Required=false)]
        public string ContactCity { get; set; }

        [NameInMap("ContactDistrict")]
        [Validation(Required=false)]
        public string ContactDistrict { get; set; }

        [NameInMap("ContactEmail")]
        [Validation(Required=false)]
        public string ContactEmail { get; set; }

        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        [NameInMap("ContactNumber")]
        [Validation(Required=false)]
        public string ContactNumber { get; set; }

        [NameInMap("ContactProvince")]
        [Validation(Required=false)]
        public string ContactProvince { get; set; }

        [NameInMap("ContactZipCode")]
        [Validation(Required=false)]
        public string ContactZipCode { get; set; }

    }

}
