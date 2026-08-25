// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class BatchDeleteModelsRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public BatchDeleteModelsRequestBody Body { get; set; }
        public class BatchDeleteModelsRequestBody : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("modelIds")]
            [Validation(Required=false)]
            public List<string> ModelIds { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>client-token-1</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
