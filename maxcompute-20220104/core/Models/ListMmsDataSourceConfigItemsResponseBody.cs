// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListMmsDataSourceConfigItemsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListMmsDataSourceConfigItemsResponseBodyData> Data { get; set; }
        public class ListMmsDataSourceConfigItemsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>MaxCompute Default Project</para>
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("enums")]
            [Validation(Required=false)]
            public List<string> Enums { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>group.basic</para>
            /// </summary>
            [NameInMap("group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mc.default.project</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MaxCompute Default Project</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>project</para>
            /// </summary>
            [NameInMap("placeHolder")]
            [Validation(Required=false)]
            public string PlaceHolder { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            [NameInMap("subItems")]
            [Validation(Required=false)]
            public Dictionary<string, object> SubItems { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>.keytab</para>
            /// </summary>
            [NameInMap("subType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>STRING</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p1=1/p2=abc</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public object Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>688003E1-D1B4-5468-957E-2FFB3AC8D79B</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
