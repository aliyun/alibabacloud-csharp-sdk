// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeEncryptionKeyListResponseBody : TeaModel {
        /// <summary>
        /// <para>The custom keys that are available in the region.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10E2160B-959C-5C3E-BFE6-86EC5925****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
