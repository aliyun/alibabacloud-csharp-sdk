// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160701.Models
{
    public class DescribeSystemParametersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SystemParameters")]
        [Validation(Required=false)]
        public DescribeSystemParametersResponseBodySystemParameters SystemParameters { get; set; }
        public class DescribeSystemParametersResponseBodySystemParameters : TeaModel {
            [NameInMap("SystemParameter")]
            [Validation(Required=false)]
            public List<DescribeSystemParametersResponseBodySystemParametersSystemParameter> SystemParameter { get; set; }
            public class DescribeSystemParametersResponseBodySystemParametersSystemParameter : TeaModel {
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ParamName")]
                [Validation(Required=false)]
                public string ParamName { get; set; }

                [NameInMap("ParamType")]
                [Validation(Required=false)]
                public string ParamType { get; set; }

            }

        }

    }

}
