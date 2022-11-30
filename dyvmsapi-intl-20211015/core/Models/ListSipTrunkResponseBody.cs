// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class ListSipTrunkResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListSipTrunkResponseBodyList> List { get; set; }
        public class ListSipTrunkResponseBodyList : TeaModel {
            [NameInMap("ApplyId")]
            [Validation(Required=false)]
            public string ApplyId { get; set; }

            [NameInMap("ApplyNote")]
            [Validation(Required=false)]
            public string ApplyNote { get; set; }

            [NameInMap("AuditNote")]
            [Validation(Required=false)]
            public string AuditNote { get; set; }

            [NameInMap("AuditTs")]
            [Validation(Required=false)]
            public string AuditTs { get; set; }

            [NameInMap("CommitTs")]
            [Validation(Required=false)]
            public string CommitTs { get; set; }

            [NameInMap("CountryId")]
            [Validation(Required=false)]
            public string CountryId { get; set; }

            [NameInMap("InboundIpPorts")]
            [Validation(Required=false)]
            public string InboundIpPorts { get; set; }

            [NameInMap("OutboundIps")]
            [Validation(Required=false)]
            public string OutboundIps { get; set; }

            [NameInMap("QualificationId")]
            [Validation(Required=false)]
            public string QualificationId { get; set; }

            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UpdateTs")]
            [Validation(Required=false)]
            public string UpdateTs { get; set; }

            [NameInMap("UserUuid")]
            [Validation(Required=false)]
            public string UserUuid { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
