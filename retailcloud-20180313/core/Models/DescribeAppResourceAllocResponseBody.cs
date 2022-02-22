// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class DescribeAppResourceAllocResponseBody : TeaModel {
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
        public DescribeAppResourceAllocResponseBodyResult Result { get; set; }
        public class DescribeAppResourceAllocResponseBodyResult : TeaModel {
            [NameInMap("AppEnvId")]
            [Validation(Required=false)]
            public long? AppEnvId { get; set; }
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("ResourceDef")]
            [Validation(Required=false)]
            public string ResourceDef { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
