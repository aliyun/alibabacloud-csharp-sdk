// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class RunCTRegistrationRequest : TeaModel {
        [NameInMap("ReferenceList")]
        [Validation(Required=true)]
        public List<RunCTRegistrationRequestReferenceList> ReferenceList { get; set; }
        public class RunCTRegistrationRequestReferenceList : TeaModel {
            [NameInMap("ReferenceURL")]
            [Validation(Required=true)]
            public string ReferenceURL { get; set; }

        }

        [NameInMap("DataFormat")]
        [Validation(Required=true)]
        public string DataFormat { get; set; }

        [NameInMap("OrgName")]
        [Validation(Required=true)]
        public string OrgName { get; set; }

        [NameInMap("OrgId")]
        [Validation(Required=true)]
        public string OrgId { get; set; }

        [NameInMap("DataSourceType")]
        [Validation(Required=true)]
        public string DataSourceType { get; set; }

        [NameInMap("FloatingList")]
        [Validation(Required=true)]
        public List<RunCTRegistrationRequestFloatingList> FloatingList { get; set; }
        public class RunCTRegistrationRequestFloatingList : TeaModel {
            [NameInMap("FloatingURL")]
            [Validation(Required=true)]
            public string FloatingURL { get; set; }

        }

    }

}
