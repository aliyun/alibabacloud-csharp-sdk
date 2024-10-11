// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class UpdateSchemaPropertyRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b0eb2742-f37e-4c67-82d4-25c651c1xxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Property")]
        [Validation(Required=false)]
        public UpdateSchemaPropertyRequestProperty Property { get; set; }
        public class UpdateSchemaPropertyRequestProperty : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Array")]
            [Validation(Required=false)]
            public bool? Array { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;instanceId\&quot;:\&quot;4cc3f160-ca64-49ff-bc70-390a044a4e83\&quot;,\&quot;appId\&quot;:\&quot;1684145288664\&quot;,\&quot;commodityCode\&quot;:\&quot;dide_pre\&quot;,\&quot;dide_pre_set\&quot;:\&quot;version_ent\&quot;}</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DisplayOrder")]
            [Validation(Required=false)]
            public int? DisplayOrder { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>textbox</para>
            /// </summary>
            [NameInMap("EditorType")]
            [Validation(Required=false)]
            public string EditorType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxLength")]
            [Validation(Required=false)]
            public int? MaxLength { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Maximum")]
            [Validation(Required=false)]
            public double? Maximum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinLength")]
            [Validation(Required=false)]
            public int? MinLength { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10800</para>
            /// </summary>
            [NameInMap("Minimum")]
            [Validation(Required=false)]
            public double? Minimum { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>(.*)</para>
            /// </summary>
            [NameInMap("Pattern")]
            [Validation(Required=false)]
            public string Pattern { get; set; }

            [NameInMap("PatternErrorMessage")]
            [Validation(Required=false)]
            public string PatternErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ReadOnly")]
            [Validation(Required=false)]
            public bool? ReadOnly { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

        }

        /// <summary>
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
