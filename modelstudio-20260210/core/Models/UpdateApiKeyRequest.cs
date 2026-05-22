// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class UpdateApiKeyRequest : TeaModel {
        [NameInMap("auth")]
        [Validation(Required=false)]
        public UpdateApiKeyRequestAuth Auth { get; set; }
        public class UpdateApiKeyRequestAuth : TeaModel {
            [NameInMap("accessIps")]
            [Validation(Required=false)]
            public List<string> AccessIps { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>update description.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
