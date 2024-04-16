// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class JobDriver : TeaModel {
        [NameInMap("sparkSubmit")]
        [Validation(Required=false)]
        public JobDriverSparkSubmit SparkSubmit { get; set; }
        public class JobDriverSparkSubmit : TeaModel {
            [NameInMap("entryPoint")]
            [Validation(Required=false)]
            public string EntryPoint { get; set; }

            [NameInMap("entryPointArguments")]
            [Validation(Required=false)]
            public List<string> EntryPointArguments { get; set; }

            [NameInMap("sparkSubmitParameters")]
            [Validation(Required=false)]
            public string SparkSubmitParameters { get; set; }

        }

    }

}
