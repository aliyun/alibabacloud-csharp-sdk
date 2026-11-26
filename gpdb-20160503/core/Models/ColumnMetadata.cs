// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ColumnMetadata : TeaModel {
        /// <summary>
        /// <para>The default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;example&quot;::text</para>
        /// </summary>
        [NameInMap("ColumnDefault")]
        [Validation(Required=false)]
        public string ColumnDefault { get; set; }

        /// <summary>
        /// <para>The column description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample column comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The data type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <para>Indicates whether the column is case-sensitive.</para>
        /// </summary>
        [NameInMap("IsCaseSensitive")]
        [Validation(Required=false)]
        public bool? IsCaseSensitive { get; set; }

        /// <summary>
        /// <para>Indicates whether the column stores currency values.</para>
        /// </summary>
        [NameInMap("IsCurrency")]
        [Validation(Required=false)]
        public bool? IsCurrency { get; set; }

        /// <summary>
        /// <para>Indicates whether the column is a primary key.</para>
        /// </summary>
        [NameInMap("IsPrimaryKey")]
        [Validation(Required=false)]
        public bool? IsPrimaryKey { get; set; }

        /// <summary>
        /// <para>Indicates whether the column is signed.</para>
        /// </summary>
        [NameInMap("IsSigned")]
        [Validation(Required=false)]
        public bool? IsSigned { get; set; }

        /// <summary>
        /// <para>The maximum character length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>255</para>
        /// </summary>
        [NameInMap("MaxLength")]
        [Validation(Required=false)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// <para>The column name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>content</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Indicates whether NULL values are allowed.</para>
        /// </summary>
        [NameInMap("Nullable")]
        [Validation(Required=false)]
        public bool? Nullable { get; set; }

        /// <summary>
        /// <para>The column precision, which indicates the total number of digits in the integer and fractional parts of a decimal number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Precision")]
        [Validation(Required=false)]
        public int? Precision { get; set; }

        /// <summary>
        /// <para>The column scale, which indicates the number of digits in the fractional part of a decimal number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Scale")]
        [Validation(Required=false)]
        public int? Scale { get; set; }

        /// <summary>
        /// <para>The schema name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ns1</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>The table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc1</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The name of the base data type used by the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("UdtName")]
        [Validation(Required=false)]
        public string UdtName { get; set; }

    }

}
