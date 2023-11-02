// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeOperatorsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeOperatorsResponseBodyData> Data { get; set; }
        public class DescribeOperatorsResponseBodyData : TeaModel {
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("OperatorDescCn")]
            [Validation(Required=false)]
            public string OperatorDescCn { get; set; }

            [NameInMap("OperatorDescEn")]
            [Validation(Required=false)]
            public string OperatorDescEn { get; set; }

            [NameInMap("OperatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            [NameInMap("SupportDataType")]
            [Validation(Required=false)]
            public string SupportDataType { get; set; }

            [NameInMap("SupportTag")]
            [Validation(Required=false)]
            public List<string> SupportTag { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
