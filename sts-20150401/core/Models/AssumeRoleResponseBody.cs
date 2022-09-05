// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sts20150401.Models
{
    public class AssumeRoleResponseBody : TeaModel {
        [NameInMap("AssumedRoleUser")]
        [Validation(Required=false)]
        public AssumeRoleResponseBodyAssumedRoleUser AssumedRoleUser { get; set; }
        public class AssumeRoleResponseBodyAssumedRoleUser : TeaModel {
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            [NameInMap("AssumedRoleId")]
            [Validation(Required=false)]
            public string AssumedRoleId { get; set; }

        }

        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public AssumeRoleResponseBodyCredentials Credentials { get; set; }
        public class AssumeRoleResponseBodyCredentials : TeaModel {
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
