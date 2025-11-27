// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetAddonSchemaResponseBody : TeaModel {
        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<GetAddonSchemaResponseBodyFields> Fields { get; set; }
        public class GetAddonSchemaResponseBodyFields : TeaModel {
            [NameInMap("conditions")]
            [Validation(Required=false)]
            public List<GetAddonSchemaResponseBodyFieldsConditions> Conditions { get; set; }
            public class GetAddonSchemaResponseBodyFieldsConditions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>redeploy</para>
                /// </summary>
                [NameInMap("action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("field")]
                [Validation(Required=false)]
                public string Field { get; set; }

                [NameInMap("op")]
                [Validation(Required=false)]
                public string Op { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{\&quot;count\&quot;: \&quot;1\&quot;, \&quot;max\&quot;: \&quot;358.106\&quot;, \&quot;sum\&quot;: \&quot;358.106\&quot;, \&quot;ts\&quot;: \&quot;1755049815000000\&quot;, \&quot;min\&quot;: \&quot;358.106\&quot;}, {\&quot;count\&quot;: \&quot;1\&quot;, \&quot;max\&quot;: \&quot;326.311\&quot;, \&quot;sum\&quot;: \&quot;326.311\&quot;, \&quot;ts\&quot;: \&quot;1755049830000000\&quot;, \&quot;min\&quot;: \&quot;326.311\&quot;}]</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            [NameInMap("defaultValue")]
            [Validation(Required=false)]
            public object DefaultValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>o11y-demo-cn-heyuan</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            [NameInMap("element")]
            [Validation(Required=false)]
            public string Element { get; set; }

            [NameInMap("fieldPath")]
            [Validation(Required=false)]
            public string FieldPath { get; set; }

            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rum_api_dashboard_explorer_link_metric_set</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("placeholder")]
            [Validation(Required=false)]
            public string Placeholder { get; set; }

            [NameInMap("props")]
            [Validation(Required=false)]
            public GetAddonSchemaResponseBodyFieldsProps Props { get; set; }
            public class GetAddonSchemaResponseBodyFieldsProps : TeaModel {
                /// <summary>
                /// <para>AK</para>
                /// </summary>
                [NameInMap("dataSource")]
                [Validation(Required=false)]
                public List<GetAddonSchemaResponseBodyFieldsPropsDataSource> DataSource { get; set; }
                public class GetAddonSchemaResponseBodyFieldsPropsDataSource : TeaModel {
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[]</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("related")]
                [Validation(Required=false)]
                public List<string> Related { get; set; }

                [NameInMap("selectMode")]
                [Validation(Required=false)]
                public string SelectMode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xtrace</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("validation")]
            [Validation(Required=false)]
            public GetAddonSchemaResponseBodyFieldsValidation Validation { get; set; }
            public class GetAddonSchemaResponseBodyFieldsValidation : TeaModel {
                [NameInMap("max")]
                [Validation(Required=false)]
                public int? Max { get; set; }

                [NameInMap("maxLength")]
                [Validation(Required=false)]
                public int? MaxLength { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("min")]
                [Validation(Required=false)]
                public int? Min { get; set; }

                [NameInMap("minLength")]
                [Validation(Required=false)]
                public int? MinLength { get; set; }

                [NameInMap("regular")]
                [Validation(Required=false)]
                public string Regular { get; set; }

                [NameInMap("required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E5B1D3D4-BB28-5996-8AD2-***********</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>response_time</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
