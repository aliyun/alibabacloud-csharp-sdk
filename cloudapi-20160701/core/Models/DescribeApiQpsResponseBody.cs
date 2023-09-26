// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160701.Models
{
    public class DescribeApiQpsResponseBody : TeaModel {
        [NameInMap("Fails")]
        [Validation(Required=false)]
        public DescribeApiQpsResponseBodyFails Fails { get; set; }
        public class DescribeApiQpsResponseBodyFails : TeaModel {
            [NameInMap("Fail")]
            [Validation(Required=false)]
            public List<DescribeApiQpsResponseBodyFailsFail> Fail { get; set; }
            public class DescribeApiQpsResponseBodyFailsFail : TeaModel {
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Successes")]
        [Validation(Required=false)]
        public DescribeApiQpsResponseBodySuccesses Successes { get; set; }
        public class DescribeApiQpsResponseBodySuccesses : TeaModel {
            [NameInMap("Success")]
            [Validation(Required=false)]
            public List<DescribeApiQpsResponseBodySuccessesSuccess> Success { get; set; }
            public class DescribeApiQpsResponseBodySuccessesSuccess : TeaModel {
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
