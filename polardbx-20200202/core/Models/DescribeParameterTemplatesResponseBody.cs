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
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                [NameInMap("Dynamic")]
                [Validation(Required=false)]
                public int? Dynamic { get; set; }

                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

                [NameInMap("Revisable")]
                [Validation(Required=false)]
                public int? Revisable { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
