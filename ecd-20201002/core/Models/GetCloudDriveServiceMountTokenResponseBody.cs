// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class GetCloudDriveServiceMountTokenResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public GetCloudDriveServiceMountTokenResponseBodyToken Token { get; set; }
        public class GetCloudDriveServiceMountTokenResponseBodyToken : TeaModel {
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            [NameInMap("ExpiredAfter")]
            [Validation(Required=false)]
            public string ExpiredAfter { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

            [NameInMap("UsedSize")]
            [Validation(Required=false)]
            public long? UsedSize { get; set; }

        }

    }

}
