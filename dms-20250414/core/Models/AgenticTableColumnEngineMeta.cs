// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticTableColumnEngineMeta : TeaModel {
        /// <summary>
        /// <para>Specifies whether the field is auto-incremented.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoIncrement")]
        [Validation(Required=false)]
        public bool? AutoIncrement { get; set; }

        /// <summary>
        /// <para>The defined length of the field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DataLength")]
        [Validation(Required=false)]
        public long? DataLength { get; set; }

        /// <summary>
        /// <para>The precision of the numeric field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DataPrecision")]
        [Validation(Required=false)]
        public int? DataPrecision { get; set; }

        /// <summary>
        /// <para>The scale of the numeric field, which is the number of decimal places.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DataScale")]
        [Validation(Required=false)]
        public int? DataScale { get; set; }

        /// <summary>
        /// <para>The default value of the field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// <para>The character set of the field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>utf8mb4</para>
        /// </summary>
        [NameInMap("Encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        /// <summary>
        /// <para>The additional information of the field, such as auto_increment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto_increment</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        /// <summary>
        /// <para>Specifies whether the field is a generated column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GenerationColumn")]
        [Validation(Required=false)]
        public bool? GenerationColumn { get; set; }

        /// <summary>
        /// <para>The calculation expression of the generated column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>price * quantity</para>
        /// </summary>
        [NameInMap("GenerationExpression")]
        [Validation(Required=false)]
        public string GenerationExpression { get; set; }

        /// <summary>
        /// <para>Specifies whether the field allows null values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Nullable")]
        [Validation(Required=false)]
        public bool? Nullable { get; set; }

    }

}
