// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeRenderingInstanceConfigurationResponseBody : TeaModel {
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public List<DescribeRenderingInstanceConfigurationResponseBodyConfiguration> Configuration { get; set; }
        public class DescribeRenderingInstanceConfigurationResponseBodyConfiguration : TeaModel {
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<DescribeRenderingInstanceConfigurationResponseBodyConfigurationAttributes> Attributes { get; set; }
            public class DescribeRenderingInstanceConfigurationResponseBodyConfigurationAttributes : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
