// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class GetSupabaseProjectApiKeysResponseBody : TeaModel {
        [NameInMap("ApiKeys")]
        [Validation(Required=false)]
        public List<GetSupabaseProjectApiKeysResponseBodyApiKeys> ApiKeys { get; set; }
        public class GetSupabaseProjectApiKeysResponseBodyApiKeys : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Tmz2Z59caMDeq/Xi9vuc****</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>anon key</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
