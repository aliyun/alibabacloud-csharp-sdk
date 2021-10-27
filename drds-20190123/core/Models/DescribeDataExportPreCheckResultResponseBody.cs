// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDataExportPreCheckResultResponseBody : TeaModel {
        [NameInMap("PreCheckResult")]
        [Validation(Required=false)]
        public DescribeDataExportPreCheckResultResponseBodyPreCheckResult PreCheckResult { get; set; }
        public class DescribeDataExportPreCheckResultResponseBodyPreCheckResult : TeaModel {
            [NameInMap("PreCheckName")]
            [Validation(Required=false)]
            public string PreCheckName { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("SubCheckItems")]
            [Validation(Required=false)]
            public DescribeDataExportPreCheckResultResponseBodyPreCheckResultSubCheckItems SubCheckItems { get; set; }
            public class DescribeDataExportPreCheckResultResponseBodyPreCheckResultSubCheckItems : TeaModel {
                [NameInMap("SubCheckItems")]
                [Validation(Required=false)]
                public List<DescribeDataExportPreCheckResultResponseBodyPreCheckResultSubCheckItemsSubCheckItems> SubCheckItems { get; set; }
                public class DescribeDataExportPreCheckResultResponseBodyPreCheckResultSubCheckItemsSubCheckItems : TeaModel {
                    [NameInMap("ErrorMsgCode")]
                    [Validation(Required=false)]
                    public string ErrorMsgCode { get; set; }

                    [NameInMap("ErrorMsgParams")]
                    [Validation(Required=false)]
                    public DescribeDataExportPreCheckResultResponseBodyPreCheckResultSubCheckItemsSubCheckItemsErrorMsgParams ErrorMsgParams { get; set; }
                    public class DescribeDataExportPreCheckResultResponseBodyPreCheckResultSubCheckItemsSubCheckItemsErrorMsgParams : TeaModel {
                        [NameInMap("ErrorMsgParams")]
                        [Validation(Required=false)]
                        public List<string> ErrorMsgParams { get; set; }
                    };

                    [NameInMap("PreCheckItemName")]
                    [Validation(Required=false)]
                    public string PreCheckItemName { get; set; }

                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
