// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class UpdateFunctionInstanceRequest : TeaModel {
        [NameInMap("createParameters")]
        [Validation(Required=false)]
        public List<UpdateFunctionInstanceRequestCreateParameters> CreateParameters { get; set; }
        public class UpdateFunctionInstanceRequestCreateParameters : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("cron")]
        [Validation(Required=false)]
        public string Cron { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("usageParameters")]
        [Validation(Required=false)]
        public List<UpdateFunctionInstanceRequestUsageParameters> UsageParameters { get; set; }
        public class UpdateFunctionInstanceRequestUsageParameters : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
