// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListMmsDataSourceConfigItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of configuration items.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListMmsDataSourceConfigItemsResponseBodyData> Data { get; set; }
        public class ListMmsDataSourceConfigItemsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The description of the configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute Default Project</para>
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>The enumerated values for the configuration item.</para>
            /// </summary>
            [NameInMap("enums")]
            [Validation(Required=false)]
            public List<string> Enums { get; set; }

            /// <summary>
            /// <para>The group to which the configuration item belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group.basic</para>
            /// </summary>
            [NameInMap("group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <para>The key of the configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mc.default.project</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The name of the configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute Default Project</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The placeholder for the configuration value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project</para>
            /// </summary>
            [NameInMap("placeHolder")]
            [Validation(Required=false)]
            public string PlaceHolder { get; set; }

            /// <summary>
            /// <para>Indicates whether the configuration item is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            /// <summary>
            /// <para>The sub-items of the configuration item.</para>
            /// </summary>
            [NameInMap("subItems")]
            [Validation(Required=false)]
            public Dictionary<string, object> SubItems { get; set; }

            /// <summary>
            /// <para>The file type. This parameter is valid only when <c>type</c> is <c>file</c>. For example, .keytab.</para>
            /// 
            /// <b>Example:</b>
            /// <para>.keytab</para>
            /// </summary>
            [NameInMap("subType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            /// <summary>
            /// <para>The data type of the configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STRING</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The value of the configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p1=1/p2=abc</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public object Value { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>688003E1-D1B4-5468-957E-2FFB3AC8D79B</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
