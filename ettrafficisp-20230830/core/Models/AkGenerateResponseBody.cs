// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EttrafficIsp20230830.Models
{
    public class AkGenerateResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public AkGenerateResponseBodyData Data { get; set; }
        public class AkGenerateResponseBodyData : TeaModel {
            /// <summary>
            /// Access Key ID
            /// </summary>
            [NameInMap("accessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            [NameInMap("accessKeyName")]
            [Validation(Required=false)]
            public string AccessKeyName { get; set; }

            [NameInMap("accessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
