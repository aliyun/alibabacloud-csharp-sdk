// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class DescribeAppEnvironmentDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAppEnvironmentDetailResponseBodyResult Result { get; set; }
        public class DescribeAppEnvironmentDetailResponseBodyResult : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }
            [NameInMap("AppSchemaId")]
            [Validation(Required=false)]
            public long? AppSchemaId { get; set; }
            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public long? EnvId { get; set; }
            [NameInMap("EnvName")]
            [Validation(Required=false)]
            public string EnvName { get; set; }
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public int? EnvType { get; set; }
            [NameInMap("EnvTypeName")]
            [Validation(Required=false)]
            public string EnvTypeName { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("Replicas")]
            [Validation(Required=false)]
            public int? Replicas { get; set; }
        };

    }

}
