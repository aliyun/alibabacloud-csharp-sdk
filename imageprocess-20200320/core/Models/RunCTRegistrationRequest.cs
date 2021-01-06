// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class RunCTRegistrationRequest : TeaModel {
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        [NameInMap("DataFormat")]
        [Validation(Required=false)]
        public string DataFormat { get; set; }

        [NameInMap("OrgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        [NameInMap("ReferenceList")]
        [Validation(Required=false)]
        public List<RunCTRegistrationRequestReferenceList> ReferenceList { get; set; }
        public class RunCTRegistrationRequestReferenceList : TeaModel {
            [NameInMap("ReferenceURL")]
            [Validation(Required=false)]
            public string ReferenceURL { get; set; }

        }

        [NameInMap("FloatingList")]
        [Validation(Required=false)]
        public List<RunCTRegistrationRequestFloatingList> FloatingList { get; set; }
        public class RunCTRegistrationRequestFloatingList : TeaModel {
            [NameInMap("FloatingURL")]
            [Validation(Required=false)]
            public string FloatingURL { get; set; }

        }

    }

}
