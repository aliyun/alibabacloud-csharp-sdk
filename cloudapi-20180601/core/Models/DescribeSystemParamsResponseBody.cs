// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20180601.Models
{
    public class DescribeSystemParamsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SystemParams")]
        [Validation(Required=false)]
        public DescribeSystemParamsResponseBodySystemParams SystemParams { get; set; }
        public class DescribeSystemParamsResponseBodySystemParams : TeaModel {
            [NameInMap("SystemParam")]
            [Validation(Required=false)]
            public List<DescribeSystemParamsResponseBodySystemParamsSystemParam> SystemParam { get; set; }
            public class DescribeSystemParamsResponseBodySystemParamsSystemParam : TeaModel {
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
