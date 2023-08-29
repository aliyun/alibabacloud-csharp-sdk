// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trusted_server20200613.Models
{
    public class DescribeBootResponseBody : TeaModel {
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WhiteListAffiliation")]
        [Validation(Required=false)]
        public int? WhiteListAffiliation { get; set; }

        [NameInMap("WhiteListDetail")]
        [Validation(Required=false)]
        public string WhiteListDetail { get; set; }

    }

}
