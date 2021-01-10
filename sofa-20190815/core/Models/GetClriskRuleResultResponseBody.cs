// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetClriskRuleResultResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Heads")]
        [Validation(Required=false)]
        public List<string> Heads { get; set; }

        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<GetClriskRuleResultResponseBodyValues> Values { get; set; }
        public class GetClriskRuleResultResponseBodyValues : TeaModel {
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

    }

}
