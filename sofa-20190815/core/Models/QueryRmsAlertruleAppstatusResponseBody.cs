// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsAlertruleAppstatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public QueryRmsAlertruleAppstatusResponseBodyResponse Response { get; set; }
        public class QueryRmsAlertruleAppstatusResponseBodyResponse : TeaModel {
            [NameInMap("ItemTypeAlerting")]
            [Validation(Required=false)]
            public List<string> ItemTypeAlerting { get; set; }
            [NameInMap("ItemTypeConfigured")]
            [Validation(Required=false)]
            public List<string> ItemTypeConfigured { get; set; }
            [NameInMap("ItemTypeNotConfigured")]
            [Validation(Required=false)]
            public List<string> ItemTypeNotConfigured { get; set; }
        };

    }

}
