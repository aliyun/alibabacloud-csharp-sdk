// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetFormDataByIDResponseBody : TeaModel {
        [NameInMap("formData")]
        [Validation(Required=false)]
        public Dictionary<string, object> FormData { get; set; }

        [NameInMap("formInstId")]
        [Validation(Required=false)]
        public string FormInstId { get; set; }

        [NameInMap("modifiedTimeGMT")]
        [Validation(Required=false)]
        public string ModifiedTimeGMT { get; set; }

        [NameInMap("originator")]
        [Validation(Required=false)]
        public GetFormDataByIDResponseBodyOriginator Originator { get; set; }
        public class GetFormDataByIDResponseBodyOriginator : TeaModel {
            [NameInMap("DepartmentName")]
            [Validation(Required=false)]
            public string DepartmentName { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public GetFormDataByIDResponseBodyOriginatorName Name { get; set; }
            public class GetFormDataByIDResponseBodyOriginatorName : TeaModel {
                [NameInMap("NameInChinese")]
                [Validation(Required=false)]
                public string NameInChinese { get; set; }

                [NameInMap("NameInEnglish")]
                [Validation(Required=false)]
                public string NameInEnglish { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
