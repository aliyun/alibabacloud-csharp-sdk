// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class RunCTRegistrationAdvanceRequest : TeaModel {
        /// <summary>
        /// DICOM。
        /// </summary>
        [NameInMap("DataFormat")]
        [Validation(Required=false)]
        public string DataFormat { get; set; }

        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        [NameInMap("FloatingList")]
        [Validation(Required=false)]
        public List<RunCTRegistrationAdvanceRequestFloatingList> FloatingList { get; set; }
        public class RunCTRegistrationAdvanceRequestFloatingList : TeaModel {
            [NameInMap("FloatingURL")]
            [Validation(Required=false)]
            public Stream FloatingURLObject { get; set; }

        }

        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        [NameInMap("OrgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        [NameInMap("ReferenceList")]
        [Validation(Required=false)]
        public List<RunCTRegistrationAdvanceRequestReferenceList> ReferenceList { get; set; }
        public class RunCTRegistrationAdvanceRequestReferenceList : TeaModel {
            [NameInMap("ReferenceURL")]
            [Validation(Required=false)]
            public Stream ReferenceURLObject { get; set; }

        }

    }

}
