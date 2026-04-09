// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class ListProductsResponseBody : TeaModel {
        [NameInMap("products")]
        [Validation(Required=false)]
        public List<ListProductsResponseBodyProducts> Products { get; set; }
        public class ListProductsResponseBodyProducts : TeaModel {
            [NameInMap("category2Name")]
            [Validation(Required=false)]
            public string Category2Name { get; set; }

            [NameInMap("categoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Ecs</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2014-05-26</para>
            /// </summary>
            [NameInMap("defaultVersion")]
            [Validation(Required=false)]
            public string DefaultVersion { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("shortName")]
            [Validation(Required=false)]
            public string ShortName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RPC</para>
            /// </summary>
            [NameInMap("style")]
            [Validation(Required=false)]
            public string Style { get; set; }

            [NameInMap("versions")]
            [Validation(Required=false)]
            public List<string> Versions { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9BFC4AC1-6BE4-5405-BDEC-CA288D404812</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
