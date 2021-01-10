// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkelinkflowLinkflowGetcurrentuserResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLinkelinkflowLinkflowGetcurrentuserResponseBodyData Data { get; set; }
        public class GetLinkelinkflowLinkflowGetcurrentuserResponseBodyData : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }
            [NameInMap("Admin")]
            [Validation(Required=false)]
            public bool? Admin { get; set; }
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }
            [NameInMap("EmpId")]
            [Validation(Required=false)]
            public string EmpId { get; set; }
            [NameInMap("FirstName")]
            [Validation(Required=false)]
            public string FirstName { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("IsPictureSet")]
            [Validation(Required=false)]
            public bool? IsPictureSet { get; set; }
            [NameInMap("LastName")]
            [Validation(Required=false)]
            public string LastName { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }
        };

    }

}
