// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeKmsKeysResponseBody : TeaModel {
        [NameInMap("AuthorizeStatus")]
        [Validation(Required=false)]
        public string AuthorizeStatus { get; set; }

        [NameInMap("Keys")]
        [Validation(Required=false)]
        public List<DescribeKmsKeysResponseBodyKeys> Keys { get; set; }
        public class DescribeKmsKeysResponseBodyKeys : TeaModel {
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("KmsServiceStatus")]
        [Validation(Required=false)]
        public string KmsServiceStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
