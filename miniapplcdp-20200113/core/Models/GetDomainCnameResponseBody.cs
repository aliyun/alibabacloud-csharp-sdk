// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class GetDomainCnameResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDomainCnameResponseBodyData Data { get; set; }
        public class GetDomainCnameResponseBodyData : TeaModel {
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
