// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SenderStatisticsDetailByParamResponseBody : TeaModel {
        [NameInMap("NextStart")]
        [Validation(Required=false)]
        public string NextStart { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public SenderStatisticsDetailByParamResponseBodyData Data { get; set; }
        public class SenderStatisticsDetailByParamResponseBodyData : TeaModel {
            [NameInMap("mailDetail")]
            [Validation(Required=false)]
            public List<SenderStatisticsDetailByParamResponseBodyDataMailDetail> MailDetail { get; set; }
            public class SenderStatisticsDetailByParamResponseBodyDataMailDetail : TeaModel {
                public string AccountName { get; set; }
                public string LastUpdateTime { get; set; }
                public string Message { get; set; }
                public int? Status { get; set; }
                public string ToAddress { get; set; }
                public string UtcLastUpdateTime { get; set; }
            }
        };

    }

}
