// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateModelRequest : TeaModel {
        /// <summary>
        /// <para>The request body for updating the model. At least one non-null parameter must be provided among description, contextSize, maxTokens, and capabilities.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateModelRequestBody Body { get; set; }
        public class UpdateModelRequestBody : TeaModel {
            /// <summary>
            /// <para>The model description. The maximum length is 255 characters after leading and trailing whitespace is removed. Pass an empty string to clear the description. If this parameter is not provided or set to null, the original value is retained. Modifying only the description does not refresh the model configuration of associated agents.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// <para>The client token for idempotence. Not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-1</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
