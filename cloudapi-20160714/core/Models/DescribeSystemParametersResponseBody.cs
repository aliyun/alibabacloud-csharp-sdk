// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeSystemParametersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SystemParams")]
        [Validation(Required=false)]
        public DescribeSystemParametersResponseBodySystemParams SystemParams { get; set; }
        public class DescribeSystemParametersResponseBodySystemParams : TeaModel {
            [NameInMap("SystemParamItem")]
            [Validation(Required=false)]
            public List<DescribeSystemParametersResponseBodySystemParamsSystemParamItem> SystemParamItem { get; set; }
            public class DescribeSystemParametersResponseBodySystemParamsSystemParamItem : TeaModel {
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
