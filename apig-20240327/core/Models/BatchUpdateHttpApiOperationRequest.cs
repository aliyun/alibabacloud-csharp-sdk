// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class BatchUpdateHttpApiOperationRequest : TeaModel {
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public BatchUpdateHttpApiOperationRequestAuthConfig AuthConfig { get; set; }
        public class BatchUpdateHttpApiOperationRequestAuthConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("authMode")]
            [Validation(Required=false)]
            public string AuthMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Jwt</para>
            /// </summary>
            [NameInMap("authType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuth")]
        [Validation(Required=false)]
        public bool? EnableAuth { get; set; }

        [NameInMap("operationIds")]
        [Validation(Required=false)]
        public List<string> OperationIds { get; set; }

    }

}
