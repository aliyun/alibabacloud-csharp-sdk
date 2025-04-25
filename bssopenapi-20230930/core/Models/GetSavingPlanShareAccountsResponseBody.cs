// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetSavingPlanShareAccountsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetSavingPlanShareAccountsResponseBodyData> Data { get; set; }
        public class GetSavingPlanShareAccountsResponseBodyData : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            [NameInMap("ShareTimeList")]
            [Validation(Required=false)]
            public List<GetSavingPlanShareAccountsResponseBodyDataShareTimeList> ShareTimeList { get; set; }
            public class GetSavingPlanShareAccountsResponseBodyDataShareTimeList : TeaModel {
                [NameInMap("ShareEndTime")]
                [Validation(Required=false)]
                public string ShareEndTime { get; set; }

                [NameInMap("ShareStartTime")]
                [Validation(Required=false)]
                public string ShareStartTime { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
