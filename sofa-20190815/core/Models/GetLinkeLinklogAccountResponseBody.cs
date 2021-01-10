// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeLinklogAccountResponseBody : TeaModel {
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
        public GetLinkeLinklogAccountResponseBodyResult Result { get; set; }
        public class GetLinkeLinklogAccountResponseBodyResult : TeaModel {
            [NameInMap("Begin")]
            [Validation(Required=false)]
            public long? Begin { get; set; }
            [NameInMap("BeginMills")]
            [Validation(Required=false)]
            public long? BeginMills { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }
            [NameInMap("EmpId")]
            [Validation(Required=false)]
            public string EmpId { get; set; }
            [NameInMap("End")]
            [Validation(Required=false)]
            public long? End { get; set; }
            [NameInMap("EndMills")]
            [Validation(Required=false)]
            public long? EndMills { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Role")]
            [Validation(Required=false)]
            public long? Role { get; set; }
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }
            [NameInMap("Sorter")]
            [Validation(Required=false)]
            public string Sorter { get; set; }
            [NameInMap("Stores")]
            [Validation(Required=false)]
            public List<string> Stores { get; set; }
            [NameInMap("StoreIds")]
            [Validation(Required=false)]
            public List<string> StoreIds { get; set; }
        };

    }

}
