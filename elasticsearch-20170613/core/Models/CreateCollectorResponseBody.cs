// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreateCollectorResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>8466BDFB-C513-4B8D-B4E3-5AB256AB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateCollectorResponseBodyResult Result { get; set; }
        public class CreateCollectorResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ct-cn-4135is2tj194p****</para>
            /// </summary>
            [NameInMap("resId")]
            [Validation(Required=false)]
            public string ResId { get; set; }

        }

    }

}
