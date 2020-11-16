// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListDirectoryUsersResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=true)]
        public string NextToken { get; set; }

        [NameInMap("Users")]
        [Validation(Required=true)]
        public List<ListDirectoryUsersResponseUsers> Users { get; set; }
        public class ListDirectoryUsersResponseUsers : TeaModel {
            [NameInMap("EndUser")]
            [Validation(Required=true)]
            public string EndUser { get; set; }

        }

    }

}
