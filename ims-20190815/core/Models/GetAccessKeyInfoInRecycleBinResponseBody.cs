// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetAccessKeyInfoInRecycleBinResponseBody : TeaModel {
        [NameInMap("AccessKey")]
        [Validation(Required=false)]
        public GetAccessKeyInfoInRecycleBinResponseBodyAccessKey AccessKey { get; set; }
        public class GetAccessKeyInfoInRecycleBinResponseBodyAccessKey : TeaModel {
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("DeleteDate")]
            [Validation(Required=false)]
            public string DeleteDate { get; set; }

            [NameInMap("RecycleDate")]
            [Validation(Required=false)]
            public string RecycleDate { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserPrincipalName")]
            [Validation(Required=false)]
            public string UserPrincipalName { get; set; }

            [NameInMap("UserRecycled")]
            [Validation(Required=false)]
            public bool? UserRecycled { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
