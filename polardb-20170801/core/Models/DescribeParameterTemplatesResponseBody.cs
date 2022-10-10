// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeParameterTemplatesResponseBody : TeaModel {
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("ParameterCount")]
        [Validation(Required=false)]
        public string ParameterCount { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public DescribeParameterTemplatesResponseBodyParameters Parameters { get; set; }
        public class DescribeParameterTemplatesResponseBodyParameters : TeaModel {
            [NameInMap("TemplateRecord")]
            [Validation(Required=false)]
            public List<DescribeParameterTemplatesResponseBodyParametersTemplateRecord> TemplateRecord { get; set; }
            public class DescribeParameterTemplatesResponseBodyParametersTemplateRecord : TeaModel {
                [NameInMap("CheckingCode")]
                [Validation(Required=false)]
                public string CheckingCode { get; set; }

                [NameInMap("ForceModify")]
                [Validation(Required=false)]
                public string ForceModify { get; set; }

                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public string ForceRestart { get; set; }

                [NameInMap("IsNodeAvailable")]
                [Validation(Required=false)]
                public string IsNodeAvailable { get; set; }

                [NameInMap("ParamRelyRule")]
                [Validation(Required=false)]
                public string ParamRelyRule { get; set; }

                [NameInMap("ParameterDescription")]
                [Validation(Required=false)]
                public string ParameterDescription { get; set; }

                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
