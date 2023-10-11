// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sts20150401.Models
{
    public class AssumeRoleResponseBody : TeaModel {
        /// <summary>
        /// The temporary identity that you use to assume the RAM role.
        /// </summary>
        [NameInMap("AssumedRoleUser")]
        [Validation(Required=false)]
        public AssumeRoleResponseBodyAssumedRoleUser AssumedRoleUser { get; set; }
        public class AssumeRoleResponseBodyAssumedRoleUser : TeaModel {
            /// <summary>
            /// The ARN of the temporary identity that you use to assume the RAM role.
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// The ID of the temporary identity that you use to assume the RAM role.
            /// </summary>
            [NameInMap("AssumedRoleId")]
            [Validation(Required=false)]
            public string AssumedRoleId { get; set; }

        }

        /// <summary>
        /// The STS credentials.
        /// </summary>
        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public AssumeRoleResponseBodyCredentials Credentials { get; set; }
        public class AssumeRoleResponseBodyCredentials : TeaModel {
            /// <summary>
            /// The AccessKey ID.
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// The AccessKey secret.
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// The time when the STS token expires. The time is displayed in UTC.
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            /// <summary>
            /// The STS token.
            /// 
            /// > Alibaba Cloud STS does not impose limits on the length of STS tokens. We strongly recommend that you do not specify a maximum length for STS tokens.
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
