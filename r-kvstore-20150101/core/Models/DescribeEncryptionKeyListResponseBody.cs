// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeEncryptionKeyListResponseBody : TeaModel {
        /// <summary>
        /// DescribeEncryptionKeyList
        /// </summary>
        [NameInMap("KeyIds")]
        [Validation(Required=false)]
        public DescribeEncryptionKeyListResponseBodyKeyIds KeyIds { get; set; }
        public class DescribeEncryptionKeyListResponseBodyKeyIds : TeaModel {
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public List<string> KeyId { get; set; }

        }

        /// <summary>
        /// Queries the custom keys that are available for an ApsaraDB for Redis instance to use transparent data encryption (TDE).
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
