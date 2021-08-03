// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopsInGroupResponseBody : TeaModel {
        [NameInMap("PostPaidDesktopsCount")]
        [Validation(Required=false)]
        public int? PostPaidDesktopsCount { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PaidDesktopsCount")]
        [Validation(Required=false)]
        public int? PaidDesktopsCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PostPaidDesktopsTotalAmount")]
        [Validation(Required=false)]
        public int? PostPaidDesktopsTotalAmount { get; set; }

        [NameInMap("PaidDesktops")]
        [Validation(Required=false)]
        public List<DescribeDesktopsInGroupResponseBodyPaidDesktops> PaidDesktops { get; set; }
        public class DescribeDesktopsInGroupResponseBodyPaidDesktops : TeaModel {
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            [NameInMap("EndUserName")]
            [Validation(Required=false)]
            public string EndUserName { get; set; }

        }

        [NameInMap("PostPaidDesktops")]
        [Validation(Required=false)]
        public List<DescribeDesktopsInGroupResponseBodyPostPaidDesktops> PostPaidDesktops { get; set; }
        public class DescribeDesktopsInGroupResponseBodyPostPaidDesktops : TeaModel {
            [NameInMap("CreateDuration")]
            [Validation(Required=false)]
            public string CreateDuration { get; set; }

            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public string ReleaseTime { get; set; }

            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            [NameInMap("EndUserName")]
            [Validation(Required=false)]
            public string EndUserName { get; set; }

        }

    }

}
