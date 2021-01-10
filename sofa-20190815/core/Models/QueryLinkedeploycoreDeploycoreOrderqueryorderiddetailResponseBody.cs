// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkedeploycoreDeploycoreOrderqueryorderiddetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryLinkedeploycoreDeploycoreOrderqueryorderiddetailResponseBodyData Data { get; set; }
        public class QueryLinkedeploycoreDeploycoreOrderqueryorderiddetailResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }
            [NameInMap("EnvName")]
            [Validation(Required=false)]
            public string EnvName { get; set; }
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }
            [NameInMap("OrderStatus")]
            [Validation(Required=false)]
            public string OrderStatus { get; set; }
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }
            [NameInMap("SourceApp")]
            [Validation(Required=false)]
            public string SourceApp { get; set; }
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }
        };

    }

}
