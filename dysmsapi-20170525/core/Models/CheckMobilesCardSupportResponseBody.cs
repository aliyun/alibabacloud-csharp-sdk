// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CheckMobilesCardSupportResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckMobilesCardSupportResponseBodyData Data { get; set; }
        public class CheckMobilesCardSupportResponseBodyData : TeaModel {
            [NameInMap("queryResult")]
            [Validation(Required=false)]
            public List<CheckMobilesCardSupportResponseBodyDataQueryResult> QueryResult { get; set; }
            public class CheckMobilesCardSupportResponseBodyDataQueryResult : TeaModel {
                [NameInMap("mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                [NameInMap("support")]
                [Validation(Required=false)]
                public bool? Support { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
