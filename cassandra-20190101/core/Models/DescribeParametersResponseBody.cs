// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeParametersResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public DescribeParametersResponseBodyParameters Parameters { get; set; }
        public class DescribeParametersResponseBodyParameters : TeaModel {
            [NameInMap("Parameter")]
            [Validation(Required=false)]
            public List<DescribeParametersResponseBodyParametersParameter> Parameter { get; set; }
            public class DescribeParametersResponseBodyParametersParameter : TeaModel {
                public string Value { get; set; }
                public string DataType { get; set; }
                public string Description { get; set; }
                public string Name { get; set; }
                public string DefaultValue { get; set; }
                public string AllowedValues { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
