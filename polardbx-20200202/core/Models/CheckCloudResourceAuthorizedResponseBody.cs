// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CheckCloudResourceAuthorizedResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckCloudResourceAuthorizedResponseBodyData Data { get; set; }
        public class CheckCloudResourceAuthorizedResponseBodyData : TeaModel {
            [NameInMap("AuthorizationState")]
            [Validation(Required=false)]
            public string AuthorizationState { get; set; }
            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }
        };

    }

}
