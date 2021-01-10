// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeLinklogUserinfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("ResponseContentRange")]
        [Validation(Required=false)]
        public string ResponseContentRange { get; set; }

        [NameInMap("ResponseContentType")]
        [Validation(Required=false)]
        public string ResponseContentType { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetLinkeLinklogUserinfoResponseBodyResult Result { get; set; }
        public class GetLinkeLinklogUserinfoResponseBodyResult : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }
            [NameInMap("Customer")]
            [Validation(Required=false)]
            public string Customer { get; set; }
            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }
            [NameInMap("EmpId")]
            [Validation(Required=false)]
            public string EmpId { get; set; }
            [NameInMap("LastLogin")]
            [Validation(Required=false)]
            public long? LastLogin { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }
            [NameInMap("Tenant")]
            [Validation(Required=false)]
            public string Tenant { get; set; }
            [NameInMap("UserAuthType")]
            [Validation(Required=false)]
            public string UserAuthType { get; set; }
            [NameInMap("Workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }
            [NameInMap("Tenants")]
            [Validation(Required=false)]
            public List<string> Tenants { get; set; }
        };

    }

}
