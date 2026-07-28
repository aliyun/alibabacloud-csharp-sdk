// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class DlfFieldSchema : TeaModel {
        /// <summary>
        /// <para>A comment for the field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Primary key field</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The dimension of the vector field. This parameter applies only when <c>isVectorField</c> is <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("dimension")]
        [Validation(Required=false)]
        public int? Dimension { get; set; }

        /// <summary>
        /// <para>The DLF field type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BIGINT</para>
        /// </summary>
        [NameInMap("dlfFieldType")]
        [Validation(Required=false)]
        public string DlfFieldType { get; set; }

        /// <summary>
        /// <para>The field name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id</para>
        /// </summary>
        [NameInMap("fieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// <para>Indicates whether the field is a primary key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isPrimaryKey")]
        [Validation(Required=false)]
        public bool? IsPrimaryKey { get; set; }

        /// <summary>
        /// <para>Indicates whether the DLF field type can be mapped to a Milvus field type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isSupported")]
        [Validation(Required=false)]
        public bool? IsSupported { get; set; }

        /// <summary>
        /// <para>Indicates whether the field is a vector field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isVectorField")]
        [Validation(Required=false)]
        public bool? IsVectorField { get; set; }

        /// <summary>
        /// <para>The corresponding Milvus field type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Int64</para>
        /// </summary>
        [NameInMap("milvusFieldType")]
        [Validation(Required=false)]
        public string MilvusFieldType { get; set; }

        /// <summary>
        /// <para>Indicates whether the field can be null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("nullable")]
        [Validation(Required=false)]
        public bool? Nullable { get; set; }

        /// <summary>
        /// <para>The reason the DLF field type is unsupported. This field is present only when <c>isSupported</c> is <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unsupported type</para>
        /// </summary>
        [NameInMap("unsupportedReason")]
        [Validation(Required=false)]
        public string UnsupportedReason { get; set; }

    }

}
