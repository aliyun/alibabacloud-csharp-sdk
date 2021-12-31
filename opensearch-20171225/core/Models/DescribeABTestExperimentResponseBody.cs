// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeABTestExperimentResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeABTestExperimentResponseBodyResult Result { get; set; }
        public class DescribeABTestExperimentResponseBodyResult : TeaModel {
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }
            [NameInMap("params")]
            [Validation(Required=false)]
            public DescribeABTestExperimentResponseBodyResultParams Params { get; set; }
            public class DescribeABTestExperimentResponseBodyResultParams : TeaModel {
                [NameInMap("first_formula_name")]
                [Validation(Required=false)]
                public string FirstFormulaName { get; set; }

            }
            [NameInMap("traffic")]
            [Validation(Required=false)]
            public int? Traffic { get; set; }
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }
        };

    }

}
