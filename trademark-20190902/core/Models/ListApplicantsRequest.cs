// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class ListApplicantsRequest : TeaModel {
        [NameInMap("ApplicantName")]
        [Validation(Required=false)]
        public string ApplicantName { get; set; }

        [NameInMap("ApplicantRegion")]
        [Validation(Required=false)]
        public int? ApplicantRegion { get; set; }

        [NameInMap("ApplicantType")]
        [Validation(Required=false)]
        public int? ApplicantType { get; set; }

        [NameInMap("ApplicantVersion")]
        [Validation(Required=false)]
        public string ApplicantVersion { get; set; }

        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public int? AuditStatus { get; set; }

        [NameInMap("CardNumber")]
        [Validation(Required=false)]
        public string CardNumber { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public int? PrincipalName { get; set; }

        [NameInMap("SystemVersion")]
        [Validation(Required=false)]
        public string SystemVersion { get; set; }

    }

}
