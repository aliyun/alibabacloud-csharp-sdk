// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class RemoveVpcAccessResponseBody : TeaModel {
        [NameInMap("Apis")]
        [Validation(Required=false)]
        public RemoveVpcAccessResponseBodyApis Apis { get; set; }
        public class RemoveVpcAccessResponseBodyApis : TeaModel {
            [NameInMap("Api")]
            [Validation(Required=false)]
            public List<RemoveVpcAccessResponseBodyApisApi> Api { get; set; }
            public class RemoveVpcAccessResponseBodyApisApi : TeaModel {
                public string ApiId { get; set; }
                public string GroupId { get; set; }
                public string StageId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
