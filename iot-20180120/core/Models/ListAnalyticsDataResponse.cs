// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListAnalyticsDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListAnalyticsDataResponseData Data { get; set; }
        public class ListAnalyticsDataResponseData : TeaModel {
            [NameInMap("HasNext")]
            [Validation(Required=true)]
            public bool? HasNext { get; set; }
            [NameInMap("ResultJson")]
            [Validation(Required=true)]
            public string ResultJson { get; set; }
            [NameInMap("Count")]
            [Validation(Required=true)]
            public long? Count { get; set; }
            [NameInMap("PageNum")]
            [Validation(Required=true)]
            public int? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
        };

    }

}
