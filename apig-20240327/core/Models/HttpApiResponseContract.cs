// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiResponseContract : TeaModel {
        /// <summary>
        /// <para>The content type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/json</para>
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>The response definition.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<HttpApiResponseContractItems> Items { get; set; }
        public class HttpApiResponseContractItems : TeaModel {
            /// <summary>
            /// <para>The response code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            /// <summary>
            /// <para>The response description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a description.</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The sample value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;result&quot;: &quot;ok&quot;}</para>
            /// </summary>
            [NameInMap("example")]
            [Validation(Required=false)]
            public string Example { get; set; }

            /// <summary>
            /// <para>The JSON definition description of the response body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;type&quot;: &quot;object&quot;,
            ///     &quot;required&quot;: [
            ///         &quot;result&quot;
            ///     ],
            ///     &quot;properties&quot;: {
            ///         &quot;result&quot;: {
            ///             &quot;type&quot;: &quot;string&quot;,
            ///             &quot;description&quot;: &quot;This is a description.&quot;
            ///         }
            ///     }
            /// }</para>
            /// </summary>
            [NameInMap("jsonSchema")]
            [Validation(Required=false)]
            public string JsonSchema { get; set; }

        }

    }

}
