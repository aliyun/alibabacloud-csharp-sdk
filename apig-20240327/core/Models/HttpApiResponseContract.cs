// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiResponseContract : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/json</para>
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<HttpApiResponseContractItems> Items { get; set; }
        public class HttpApiResponseContractItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>正常接口响应</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;result&quot;: &quot;ok&quot;}</para>
            /// </summary>
            [NameInMap("example")]
            [Validation(Required=false)]
            public string Example { get; set; }

            [NameInMap("jsonSchema")]
            [Validation(Required=false)]
            public string JsonSchema { get; set; }

        }

    }

}
