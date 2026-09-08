// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class UpdateSchemaPropertyRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b0eb2742-f37e-4c67-82d4-25c651c1xxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Field</para>
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public UpdateSchemaPropertyRequestProperty Property { get; set; }
        public class UpdateSchemaPropertyRequestProperty : TeaModel {
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
            /// <para>Extension attributes</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;instanceId\&quot;:\&quot;4cc3f160-ca64-49ff-bc70-390a044a4e83\&quot;,\&quot;appId\&quot;:\&quot;1684145288664\&quot;,\&quot;commodityCode\&quot;:\&quot;dide_pre\&quot;,\&quot;dide_pre_set\&quot;:\&quot;version_ent\&quot;}</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
            /// <para>Data type</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>Description.</para>
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
            /// <para>Indicates whether the property is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// <para>Display name</para>
            /// 
            /// <b>Example:</b>
            /// <para>姓名</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>Display order</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DisplayOrder")]
            [Validation(Required=false)]
            public int? DisplayOrder { get; set; }

            /// <summary>
            /// <para>Editor type</para>
            /// 
            /// <b>Example:</b>
            /// <para>textbox</para>
            /// </summary>
            [NameInMap("EditorType")]
            [Validation(Required=false)]
            public string EditorType { get; set; }

            /// <summary>
            /// <para>Maximum length</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxLength")]
            [Validation(Required=false)]
            public int? MaxLength { get; set; }

            /// <summary>
            /// <para>Maximum value</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Maximum")]
            [Validation(Required=false)]
            public double? Maximum { get; set; }

            /// <summary>
            /// <para>Minimum length</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinLength")]
            [Validation(Required=false)]
            public int? MinLength { get; set; }

            /// <summary>
            /// <para>Minimum value</para>
            /// 
            /// <b>Example:</b>
            /// <para>10800</para>
            /// </summary>
            [NameInMap("Minimum")]
            [Validation(Required=false)]
            public double? Minimum { get; set; }

            /// <summary>
            /// <para>Name</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Regular expression validation rule</para>
            /// 
            /// <b>Example:</b>
            /// <para>(.*)</para>
            /// </summary>
            [NameInMap("Pattern")]
            [Validation(Required=false)]
            public string Pattern { get; set; }

            /// <summary>
            /// <para>Regular expression validation error message</para>
            /// 
            /// <b>Example:</b>
            /// <para>不是有效的email地址</para>
            /// </summary>
            [NameInMap("PatternErrorMessage")]
            [Validation(Required=false)]
            public string PatternErrorMessage { get; set; }

            /// <summary>
            /// <para>Read-only</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ReadOnly")]
            [Validation(Required=false)]
            public bool? ReadOnly { get; set; }

            /// <summary>
            /// <para>Required</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC976D32-AC4C-4E0F-8AA9-F4BC6C4E2B3E</para>
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
