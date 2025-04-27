// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreateDataStreamResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6DCC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateDataStreamResponseBodyResult Result { get; set; }
        public class CreateDataStreamResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ds-</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
