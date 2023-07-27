// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class GetObjectAclResponseBody : TeaModel {
        [NameInMap("AccessControlList")]
        [Validation(Required=false)]
        public GetObjectAclResponseBodyAccessControlList AccessControlList { get; set; }
        public class GetObjectAclResponseBodyAccessControlList : TeaModel {
            [NameInMap("Grant")]
            [Validation(Required=false)]
            public string ACL { get; set; }

        }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public Owner Owner { get; set; }

    }

}
