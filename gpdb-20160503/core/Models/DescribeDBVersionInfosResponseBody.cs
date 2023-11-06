// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBVersionInfosResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VersionDetails")]
        [Validation(Required=false)]
        public DescribeDBVersionInfosResponseBodyVersionDetails VersionDetails { get; set; }
        public class DescribeDBVersionInfosResponseBodyVersionDetails : TeaModel {
            [NameInMap("Serverless")]
            [Validation(Required=false)]
            public object Serverless { get; set; }

            [NameInMap("StorageElastic")]
            [Validation(Required=false)]
            public object StorageElastic { get; set; }

        }

    }

}
