// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class BatchAddFeishuUsersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public BatchAddFeishuUsersResponseBodyResult Result { get; set; }
        public class BatchAddFeishuUsersResponseBodyResult : TeaModel {
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            [NameInMap("FailResults")]
            [Validation(Required=false)]
            public List<BatchAddFeishuUsersResponseBodyResultFailResults> FailResults { get; set; }
            public class BatchAddFeishuUsersResponseBodyResultFailResults : TeaModel {
                [NameInMap("FailInfos")]
                [Validation(Required=false)]
                public List<BatchAddFeishuUsersResponseBodyResultFailResultsFailInfos> FailInfos { get; set; }
                public class BatchAddFeishuUsersResponseBodyResultFailResultsFailInfos : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("CodeDesc")]
                    [Validation(Required=false)]
                    public string CodeDesc { get; set; }

                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public string Input { get; set; }

                }

            }

            [NameInMap("OkCount")]
            [Validation(Required=false)]
            public int? OkCount { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
