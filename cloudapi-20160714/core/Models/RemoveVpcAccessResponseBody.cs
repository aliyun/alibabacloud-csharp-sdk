// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class RemoveVpcAccessResponseBody : TeaModel {
        /// <summary>
        /// API operations
        /// </summary>
        [NameInMap("Apis")]
        [Validation(Required=false)]
        public RemoveVpcAccessResponseBodyApis Apis { get; set; }
        public class RemoveVpcAccessResponseBodyApis : TeaModel {
            [NameInMap("Api")]
            [Validation(Required=false)]
            public List<RemoveVpcAccessResponseBodyApisApi> Api { get; set; }
            public class RemoveVpcAccessResponseBodyApisApi : TeaModel {
                /// <summary>
                /// API Id
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// The ID of the API group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The ID of the runtime environment.
                /// </summary>
                [NameInMap("StageId")]
                [Validation(Required=false)]
                public string StageId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
