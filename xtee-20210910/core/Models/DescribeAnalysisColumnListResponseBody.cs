// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeAnalysisColumnListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeAnalysisColumnListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeAnalysisColumnListResponseBodyResultObject : TeaModel {
            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            [NameInMap("eventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("isDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            [NameInMap("variableName")]
            [Validation(Required=false)]
            public string VariableName { get; set; }

            [NameInMap("variableTitle")]
            [Validation(Required=false)]
            public string VariableTitle { get; set; }

            [NameInMap("variableType")]
            [Validation(Required=false)]
            public string VariableType { get; set; }

        }

    }

}
