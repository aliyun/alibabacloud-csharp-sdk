// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeUserVpcAuthorizationsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<DescribeUserVpcAuthorizationsResponseBodyUsers> Users { get; set; }
        public class DescribeUserVpcAuthorizationsResponseBodyUsers : TeaModel {
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            [NameInMap("AuthorizedAliyunId")]
            [Validation(Required=false)]
            public string AuthorizedAliyunId { get; set; }

            [NameInMap("AuthorizedUserId")]
            [Validation(Required=false)]
            public long? AuthorizedUserId { get; set; }

        }

    }

}
