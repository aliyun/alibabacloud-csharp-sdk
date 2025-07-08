// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QuerySmsPackageOrderListNewResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public QuerySmsPackageOrderListNewResponseBodyList List { get; set; }
        public class QuerySmsPackageOrderListNewResponseBodyList : TeaModel {
            [NameInMap("SmsPackageOrderResponse")]
            [Validation(Required=false)]
            public List<QuerySmsPackageOrderListNewResponseBodyListSmsPackageOrderResponse> SmsPackageOrderResponse { get; set; }
            public class QuerySmsPackageOrderListNewResponseBodyListSmsPackageOrderResponse : TeaModel {
                [NameInMap("EffectDate")]
                [Validation(Required=false)]
                public string EffectDate { get; set; }

                [NameInMap("ExpireDate")]
                [Validation(Required=false)]
                public string ExpireDate { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PayPrice")]
                [Validation(Required=false)]
                public string PayPrice { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public int? State { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
