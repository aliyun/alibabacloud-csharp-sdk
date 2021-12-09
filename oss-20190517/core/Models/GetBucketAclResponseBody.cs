// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class GetBucketAclResponseBody : TeaModel {
        [NameInMap("AccessControlList")]
        [Validation(Required=false)]
        public GetBucketAclResponseBodyAccessControlList AccessControlList { get; set; }
        public class GetBucketAclResponseBodyAccessControlList : TeaModel {
            [NameInMap("Grant")]
            [Validation(Required=false)]
            public string Grant { get; set; }
        };

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public Owner Owner { get; set; }

    }

}
