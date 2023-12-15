// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeCloudServiceTypeStatusResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeCloudServiceTypeStatusResponseBodyResult Result { get; set; }
        public class DescribeCloudServiceTypeStatusResponseBodyResult : TeaModel {
            [NameInMap("GrantPrivilegeUrl")]
            [Validation(Required=false)]
            public string GrantPrivilegeUrl { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            [NameInMap("ServiceOpenStatus")]
            [Validation(Required=false)]
            public bool? ServiceOpenStatus { get; set; }

            [NameInMap("ServiceOpenUrl")]
            [Validation(Required=false)]
            public string ServiceOpenUrl { get; set; }

            [NameInMap("ServicePrivilegeStatus")]
            [Validation(Required=false)]
            public bool? ServicePrivilegeStatus { get; set; }

            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
