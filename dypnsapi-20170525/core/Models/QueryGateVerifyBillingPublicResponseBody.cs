// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class QueryGateVerifyBillingPublicResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryGateVerifyBillingPublicResponseBodyData Data { get; set; }
        public class QueryGateVerifyBillingPublicResponseBodyData : TeaModel {
            [NameInMap("AmountSum")]
            [Validation(Required=false)]
            public string AmountSum { get; set; }

            [NameInMap("SceneBillingList")]
            [Validation(Required=false)]
            public List<QueryGateVerifyBillingPublicResponseBodyDataSceneBillingList> SceneBillingList { get; set; }
            public class QueryGateVerifyBillingPublicResponseBodyDataSceneBillingList : TeaModel {
                [NameInMap("Add")]
                [Validation(Required=false)]
                public string Add { get; set; }

                [NameInMap("Amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                [NameInMap("SceneCode")]
                [Validation(Required=false)]
                public string SceneCode { get; set; }

                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                [NameInMap("SinglePrice")]
                [Validation(Required=false)]
                public string SinglePrice { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
