// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class CreateApiKeyRequest : TeaModel {
        [NameInMap("auth")]
        [Validation(Required=false)]
        public CreateApiKeyRequestAuth Auth { get; set; }
        public class CreateApiKeyRequestAuth : TeaModel {
            [NameInMap("accessIps")]
            [Validation(Required=false)]
            public List<string> AccessIps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ws-8af73c50f5596193</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
