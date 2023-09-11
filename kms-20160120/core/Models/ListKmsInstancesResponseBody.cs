// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListKmsInstancesResponseBody : TeaModel {
        [NameInMap("KmsInstances")]
        [Validation(Required=false)]
        public ListKmsInstancesResponseBodyKmsInstances KmsInstances { get; set; }
        public class ListKmsInstancesResponseBodyKmsInstances : TeaModel {
            [NameInMap("KmsInstance")]
            [Validation(Required=false)]
            public List<ListKmsInstancesResponseBodyKmsInstancesKmsInstance> KmsInstance { get; set; }
            public class ListKmsInstancesResponseBodyKmsInstancesKmsInstance : TeaModel {
                [NameInMap("KmsInstanceArn")]
                [Validation(Required=false)]
                public string KmsInstanceArn { get; set; }

                [NameInMap("KmsInstanceId")]
                [Validation(Required=false)]
                public string KmsInstanceId { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
