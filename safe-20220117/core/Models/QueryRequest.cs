// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safe20220117.Models
{
    public class QueryRequest : TeaModel {
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        [NameInMap("AuthSign")]
        [Validation(Required=false)]
        public string AuthSign { get; set; }

        [NameInMap("NeedValidate")]
        [Validation(Required=false)]
        public bool? NeedValidate { get; set; }

        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        [NameInMap("ReqTimestamp")]
        [Validation(Required=false)]
        public long? ReqTimestamp { get; set; }

        [NameInMap("SourceOrderId")]
        [Validation(Required=false)]
        public string SourceOrderId { get; set; }

    }

}
