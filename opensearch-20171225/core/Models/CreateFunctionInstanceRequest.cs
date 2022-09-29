// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateFunctionInstanceRequest : TeaModel {
        [NameInMap("createParameters")]
        [Validation(Required=false)]
        public List<CreateFunctionInstanceRequestCreateParameters> CreateParameters { get; set; }
        public class CreateFunctionInstanceRequestCreateParameters : TeaModel {
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

        [NameInMap("functionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        [NameInMap("usageParameters")]
        [Validation(Required=false)]
        public List<CreateFunctionInstanceRequestUsageParameters> UsageParameters { get; set; }
        public class CreateFunctionInstanceRequestUsageParameters : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
