// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateAppGroupCredentialsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1-2-3-4</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateAppGroupCredentialsResponseBodyResult Result { get; set; }
        public class CreateAppGroupCredentialsResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>app_group_123</para>
            /// </summary>
            [NameInMap("appGroupId")]
            [Validation(Required=false)]
            public long? AppGroupId { get; set; }

            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>generated_token_string</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>api-token</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
