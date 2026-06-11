// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticTableColumnEngineMeta : TeaModel {
        /// <summary>
        /// <para>Indicates whether the column uses auto-increment.</para>
        /// </summary>
        [NameInMap("AutoIncrement")]
        [Validation(Required=false)]
        public bool? AutoIncrement { get; set; }

        /// <summary>
        /// <para>The data length of the column. This parameter typically applies to string and binary data types.</para>
        /// </summary>
        [NameInMap("DataLength")]
        [Validation(Required=false)]
        public long? DataLength { get; set; }

        /// <summary>
        /// <para>The data precision of the column, which is the total number of digits in a numeric type.</para>
        /// </summary>
        [NameInMap("DataPrecision")]
        [Validation(Required=false)]
        public int? DataPrecision { get; set; }

        /// <summary>
        /// <para>The data scale of the column, which is the number of digits to the right of the decimal point in a numeric type.</para>
        /// </summary>
        [NameInMap("DataScale")]
        [Validation(Required=false)]
        public int? DataScale { get; set; }

        /// <summary>
        /// <para>The default value of the column.</para>
        /// </summary>
        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// <para>The character encoding of the column.</para>
        /// </summary>
        [NameInMap("Encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        /// <summary>
        /// <para>Engine-specific attributes or flags for the column.</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        /// <summary>
        /// <para>Indicates whether the column is a generated column.</para>
        /// </summary>
        [NameInMap("GenerationColumn")]
        [Validation(Required=false)]
        public bool? GenerationColumn { get; set; }

        /// <summary>
        /// <para>The expression used to generate the column\&quot;s value. Applies only if <c>GenerationColumn</c> is <c>true</c>.</para>
        /// </summary>
        [NameInMap("GenerationExpression")]
        [Validation(Required=false)]
        public string GenerationExpression { get; set; }

        /// <summary>
        /// <para>Indicates whether the column is nullable.</para>
        /// </summary>
        [NameInMap("Nullable")]
        [Validation(Required=false)]
        public bool? Nullable { get; set; }

    }

}
