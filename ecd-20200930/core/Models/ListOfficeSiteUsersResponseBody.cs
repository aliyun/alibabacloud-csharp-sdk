// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListOfficeSiteUsersResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListOfficeSiteUsersResponseBodyUsers> Users { get; set; }
        public class ListOfficeSiteUsersResponseBodyUsers : TeaModel {
            [NameInMap("EndUser")]
            [Validation(Required=false)]
            public string EndUser { get; set; }

        }

    }

}
