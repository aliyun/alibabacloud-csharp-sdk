// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListAiToolsResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<ListAiToolsResponseBody> Body { get; set; }
        public class ListAiToolsResponseBody : TeaModel {
            /// <summary>
            /// <para>The fields of the tool.</para>
            /// </summary>
            [NameInMap("fields")]
            [Validation(Required=false)]
            public List<ListAiToolsResponseBodyFields> Fields { get; set; }
            public class ListAiToolsResponseBodyFields : TeaModel {
                /// <summary>
                /// <para>The name of the field.</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The valid values for the field.</para>
                /// </summary>
                [NameInMap("option")]
                [Validation(Required=false)]
                public List<string> Option { get; set; }

                /// <summary>
                /// <para>Indicates whether the field is required.</para>
                /// </summary>
                [NameInMap("required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                /// <summary>
                /// <para>The type of the field.</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>An example of the field.</para>
                /// </summary>
                [NameInMap("example")]
                [Validation(Required=false)]
                public string Example { get; set; }

                /// <summary>
                /// <para>The description of the field.</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            /// <summary>
            /// <para>The name of the tool.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The description of the tool.</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

    }

}
