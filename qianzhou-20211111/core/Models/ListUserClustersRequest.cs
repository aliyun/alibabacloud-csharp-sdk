// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qianzhou20211111.Models
{
    public class ListUserClustersRequest : TeaModel {
        [NameInMap("current")]
        [Validation(Required=false)]
        public string Current { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("userID")]
        [Validation(Required=false)]
        public string UserID { get; set; }

    }

}
