// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListDataSourceSchemasResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>022F36C7-9FB4-5D67-BEBC-3D14B0984463</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The results returned.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListDataSourceSchemasResponseBodyResult> Result { get; set; }
        public class ListDataSourceSchemasResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether the field has the index attribute. Valid values: <b>true</b> and <b>false</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("addIndex")]
            [Validation(Required=false)]
            public bool? AddIndex { get; set; }

            /// <summary>
            /// <para>Indicates whether the field is an attribute field. Valid values: <b>true</b> and <b>false</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("attribute")]
            [Validation(Required=false)]
            public bool? Attribute { get; set; }

            /// <summary>
            /// <para>Indicates whether the field is a custom field. Valid values: <b>true</b> and <b>false</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("custom")]
            [Validation(Required=false)]
            public bool? Custom { get; set; }

            /// <summary>
            /// <para>The field name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The primary key field.</para>
            /// </summary>
            [NameInMap("primaryKey")]
            [Validation(Required=false)]
            public ListDataSourceSchemasResponseBodyResultPrimaryKey PrimaryKey { get; set; }
            public class ListDataSourceSchemasResponseBodyResultPrimaryKey : TeaModel {
                /// <summary>
                /// <para>Indicates whether the field has the primary key attribute. Valid values: <b>true</b> and <b>false</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("hasPrimaryKeyAttribute")]
                [Validation(Required=false)]
                public bool? HasPrimaryKeyAttribute { get; set; }

                /// <summary>
                /// <para>Indicates whether the field is the primary key. Valid values: <b>true</b> and <b>false</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("isPrimaryKey")]
                [Validation(Required=false)]
                public bool? IsPrimaryKey { get; set; }

                /// <summary>
                /// <para>Indicates whether the field can be sorted. Valid values: <b>true</b> and <b>false</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("isPrimaryKeySorted")]
                [Validation(Required=false)]
                public bool? IsPrimaryKeySorted { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the field can be displayed. Valid values: <b>true</b> and <b>false</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("summary")]
            [Validation(Required=false)]
            public bool? Summary { get; set; }

            /// <summary>
            /// <para>The field type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STRING</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
