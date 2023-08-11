// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListServiceCredentialsResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("serviceCredentials")]
        [Validation(Required=false)]
        public List<ListServiceCredentialsResponseBodyServiceCredentials> ServiceCredentials { get; set; }
        public class ListServiceCredentialsResponseBodyServiceCredentials : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ownerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            [NameInMap("ownerStaffId")]
            [Validation(Required=false)]
            public string OwnerStaffId { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
