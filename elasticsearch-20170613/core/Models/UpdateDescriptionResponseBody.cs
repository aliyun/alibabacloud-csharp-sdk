// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateDescriptionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>FDF34727-1664-44C1-A8DA-3EB72D60****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateDescriptionResponseBodyResult Result { get; set; }
        public class UpdateDescriptionResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>aliyunes_test_name</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

    }

}
