// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetAddonSchemaResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of data table fields.</para>
        /// </summary>
        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<GetAddonSchemaResponseBodyFields> Fields { get; set; }
        public class GetAddonSchemaResponseBodyFields : TeaModel {
            /// <summary>
            /// <para>A list of display conditions.</para>
            /// </summary>
            [NameInMap("conditions")]
            [Validation(Required=false)]
            public List<GetAddonSchemaResponseBodyFieldsConditions> Conditions { get; set; }
            public class GetAddonSchemaResponseBodyFieldsConditions : TeaModel {
                /// <summary>
                /// <para>The control mode of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>show</para>
                /// </summary>
                [NameInMap("action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The name of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>store.storageTarget</para>
                /// </summary>
                [NameInMap("field")]
                [Validation(Required=false)]
                public string Field { get; set; }

                /// <summary>
                /// <para>The operator for the condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>==</para>
                /// </summary>
                [NameInMap("op")]
                [Validation(Required=false)]
                public string Op { get; set; }

                /// <summary>
                /// <para>The target value for the condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            /// <summary>
            /// <para>The default value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql.default</para>
            /// </summary>
            [NameInMap("defaultValue")]
            [Validation(Required=false)]
            public object DefaultValue { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL datasource</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Specifies whether the field is hidden. Valid values: \<c>true\\</c> (hidden) and \<c>false\\</c> (displayed).</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// <para>The type of the element.</para>
            /// 
            /// <b>Example:</b>
            /// <para>input</para>
            /// </summary>
            [NameInMap("element")]
            [Validation(Required=false)]
            public string Element { get; set; }

            /// <summary>
            /// <para>The path of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql.host</para>
            /// </summary>
            [NameInMap("fieldPath")]
            [Validation(Required=false)]
            public string FieldPath { get; set; }

            /// <summary>
            /// <para>The display name of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql</para>
            /// </summary>
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The name of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>host</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The placeholder text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Please enter the metrics collection interval</para>
            /// </summary>
            [NameInMap("placeholder")]
            [Validation(Required=false)]
            public string Placeholder { get; set; }

            /// <summary>
            /// <para>Other properties of the component.</para>
            /// </summary>
            [NameInMap("props")]
            [Validation(Required=false)]
            public GetAddonSchemaResponseBodyFieldsProps Props { get; set; }
            public class GetAddonSchemaResponseBodyFieldsProps : TeaModel {
                /// <summary>
                /// <para>The information about the data source.</para>
                /// </summary>
                [NameInMap("dataSource")]
                [Validation(Required=false)]
                public List<GetAddonSchemaResponseBodyFieldsPropsDataSource> DataSource { get; set; }
                public class GetAddonSchemaResponseBodyFieldsPropsDataSource : TeaModel {
                    /// <summary>
                    /// <para>The label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tagKey</para>
                    /// </summary>
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The value of the label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tagValue</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>A collection of related data.</para>
                /// </summary>
                [NameInMap("related")]
                [Validation(Required=false)]
                public List<string> Related { get; set; }

                /// <summary>
                /// <para>The mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>single</para>
                /// </summary>
                [NameInMap("selectMode")]
                [Validation(Required=false)]
                public string SelectMode { get; set; }

            }

            /// <summary>
            /// <para>The type of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The validation rule for the field.</para>
            /// </summary>
            [NameInMap("validation")]
            [Validation(Required=false)]
            public GetAddonSchemaResponseBodyFieldsValidation Validation { get; set; }
            public class GetAddonSchemaResponseBodyFieldsValidation : TeaModel {
                /// <summary>
                /// <para>The maximum value. The value is inclusive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("max")]
                [Validation(Required=false)]
                public int? Max { get; set; }

                /// <summary>
                /// <para>The maximum length that is supported by the text control.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("maxLength")]
                [Validation(Required=false)]
                public int? MaxLength { get; set; }

                /// <summary>
                /// <para>The details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>length limit</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The minimum value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("min")]
                [Validation(Required=false)]
                public int? Min { get; set; }

                /// <summary>
                /// <para>The minimum length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("minLength")]
                [Validation(Required=false)]
                public int? MinLength { get; set; }

                /// <summary>
                /// <para>The regular expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>^(http|https)://</para>
                /// </summary>
                [NameInMap("regular")]
                [Validation(Required=false)]
                public string Regular { get; set; }

                /// <summary>
                /// <para>Specifies whether the parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E5B1D3D4-BB28-5996-8AD2-***********</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The type of the schema.</para>
        /// 
        /// <b>Example:</b>
        /// <para>common</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
