// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAutomateResponseConfigFeatureResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAutomateResponseConfigFeatureResponseBodyData> Data { get; set; }
        public class DescribeAutomateResponseConfigFeatureResponseBodyData : TeaModel {
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            [NameInMap("Feature")]
            [Validation(Required=false)]
            public string Feature { get; set; }

            [NameInMap("RightValueEnums")]
            [Validation(Required=false)]
            public List<DescribeAutomateResponseConfigFeatureResponseBodyDataRightValueEnums> RightValueEnums { get; set; }
            public class DescribeAutomateResponseConfigFeatureResponseBodyDataRightValueEnums : TeaModel {
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("ValueMds")]
                [Validation(Required=false)]
                public string ValueMds { get; set; }

            }

            [NameInMap("SupportOperators")]
            [Validation(Required=false)]
            public List<DescribeAutomateResponseConfigFeatureResponseBodyDataSupportOperators> SupportOperators { get; set; }
            public class DescribeAutomateResponseConfigFeatureResponseBodyDataSupportOperators : TeaModel {
                [NameInMap("HasRightValue")]
                [Validation(Required=false)]
                public bool? HasRightValue { get; set; }

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
