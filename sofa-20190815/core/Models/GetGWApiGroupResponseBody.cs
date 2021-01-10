// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetGWApiGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGWApiGroupResponseBodyData Data { get; set; }
        public class GetGWApiGroupResponseBodyData : TeaModel {
            [NameInMap("ApiCount")]
            [Validation(Required=false)]
            public long? ApiCount { get; set; }
            [NameInMap("ApiGroupId")]
            [Validation(Required=false)]
            public string ApiGroupId { get; set; }
            [NameInMap("AuthUserSwitch")]
            [Validation(Required=false)]
            public string AuthUserSwitch { get; set; }
            [NameInMap("CanDelete")]
            [Validation(Required=false)]
            public bool? CanDelete { get; set; }
            [NameInMap("CanOperate")]
            [Validation(Required=false)]
            public bool? CanOperate { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }
            [NameInMap("NeedApiAuthUser")]
            [Validation(Required=false)]
            public bool? NeedApiAuthUser { get; set; }
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }
        };

    }

}
