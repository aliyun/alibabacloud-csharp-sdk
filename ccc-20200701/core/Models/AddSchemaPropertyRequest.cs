// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class AddSchemaPropertyRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b0eb2742-f37e-4c67-82d4-25c651c1xxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The property.</para>
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public AddSchemaPropertyRequestProperty Property { get; set; }
        public class AddSchemaPropertyRequestProperty : TeaModel {
            /// <summary>
            /// <para>Specifies whether the property is an array.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Array")]
            [Validation(Required=false)]
            public bool? Array { get; set; }

            /// <summary>
            /// <para>The extended attributes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;newName&quot;:&quot;Xiaoju Charging-demo&quot;,&quot;appId&quot;:&quot;69FRKB4193W8BYP0&quot;}</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
            /// <para>The data type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Specifies whether the property is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The display order in the list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DisplayOrder")]
            [Validation(Required=false)]
            public int? DisplayOrder { get; set; }

            /// <summary>
            /// <para>The editor type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>textbox</para>
            /// </summary>
            [NameInMap("EditorType")]
            [Validation(Required=false)]
            public string EditorType { get; set; }

            /// <summary>
            /// <para>The maximum length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxLength")]
            [Validation(Required=false)]
            public int? MaxLength { get; set; }

            /// <summary>
            /// <para>The maximum numeric value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Maximum")]
            [Validation(Required=false)]
            public double? Maximum { get; set; }

            /// <summary>
            /// <para>The minimum length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinLength")]
            [Validation(Required=false)]
            public int? MinLength { get; set; }

            /// <summary>
            /// <para>The minimum numeric value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Minimum")]
            [Validation(Required=false)]
            public double? Minimum { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The regular expression validation rule.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Pattern")]
            [Validation(Required=false)]
            public string Pattern { get; set; }

            /// <summary>
            /// <para>The error message for regular expression validation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Invalid format</para>
            /// </summary>
            [NameInMap("PatternErrorMessage")]
            [Validation(Required=false)]
            public string PatternErrorMessage { get; set; }

            /// <summary>
            /// <para>Specifies whether the property is read-only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ReadOnly")]
            [Validation(Required=false)]
            public bool? ReadOnly { get; set; }

            /// <summary>
            /// <para>Specifies whether the property is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03C67DAD-EB26-41D8-949D-9B0C470FB716</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>schema id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>profile</para>
        /// </summary>
        [NameInMap("SchemaId")]
        [Validation(Required=false)]
        public string SchemaId { get; set; }

    }

}
