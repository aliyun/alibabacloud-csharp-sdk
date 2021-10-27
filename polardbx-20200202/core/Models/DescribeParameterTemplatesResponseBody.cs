// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeParameterTemplatesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeParameterTemplatesResponseBodyData Data { get; set; }
        public class DescribeParameterTemplatesResponseBodyData : TeaModel {
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }
            [NameInMap("ParameterCount")]
            [Validation(Required=false)]
            public int? ParameterCount { get; set; }
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<DescribeParameterTemplatesResponseBodyDataParameters> Parameters { get; set; }
            public class DescribeParameterTemplatesResponseBodyDataParameters : TeaModel {
                public string CheckingCode { get; set; }
                public int? Dynamic { get; set; }
                public string ParameterDescription { get; set; }
                public string ParameterName { get; set; }
                public string ParameterValue { get; set; }
                public int? Revisable { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
