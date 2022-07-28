// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeJobErrorCodeResponseBody : TeaModel {
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Item")]
        [Validation(Required=false)]
        public DescribeJobErrorCodeResponseBodyItem Item { get; set; }
        public class DescribeJobErrorCodeResponseBodyItem : TeaModel {
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("JobState")]
            [Validation(Required=false)]
            public string JobState { get; set; }
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
