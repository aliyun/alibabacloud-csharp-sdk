// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class BatchUpdateHttpApiOperationRequest : TeaModel {
        /// <summary>
        /// <para>The authentication configuration. This parameter is required when enableAuth is set to true.</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public BatchUpdateHttpApiOperationRequestAuthConfig AuthConfig { get; set; }
        public class BatchUpdateHttpApiOperationRequestAuthConfig : TeaModel {
            /// <summary>
            /// <para>The authentication mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom</para>
            /// </summary>
            [NameInMap("authMode")]
            [Validation(Required=false)]
            public string AuthMode { get; set; }

            /// <summary>
            /// <para>The authentication type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Jwt</para>
            /// </summary>
            [NameInMap("authType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable consumer authentication. If set to true, a valid authConfig must be provided. If set to false, authConfig is not validated and the existing configuration remains unchanged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuth")]
        [Validation(Required=false)]
        public bool? EnableAuth { get; set; }

        /// <summary>
        /// <para>The list of operation IDs to update in batches. This parameter cannot be empty.</para>
        /// </summary>
        [NameInMap("operationIds")]
        [Validation(Required=false)]
        public List<string> OperationIds { get; set; }

    }

}
