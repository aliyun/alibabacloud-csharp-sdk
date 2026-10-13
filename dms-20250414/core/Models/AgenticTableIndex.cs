// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticTableIndex : TeaModel {
        /// <summary>
        /// <para>The list of fields included in the index. Fields with a specified prefix length include a length expression, such as name(10).</para>
        /// </summary>
        [NameInMap("ColumnNames")]
        [Validation(Required=false)]
        public List<string> ColumnNames { get; set; }

        /// <summary>
        /// <para>The index description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Index on user_id</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The index name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idx_user_id</para>
        /// </summary>
        [NameInMap("IndexName")]
        [Validation(Required=false)]
        public string IndexName { get; set; }

        /// <summary>
        /// <para>The index type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Primary</b>: primary key index</description></item>
        /// <item><description><b>Unique</b>: unique index</description></item>
        /// <item><description><b>Normal</b>: normal index</description></item>
        /// <item><description><b>FullText</b>: full-text index</description></item>
        /// <item><description><b>Spatial</b>: spatial index</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("IndexType")]
        [Validation(Required=false)]
        public string IndexType { get; set; }

        /// <summary>
        /// <para>Specifies whether the index is a primary key index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Primary")]
        [Validation(Required=false)]
        public bool? Primary { get; set; }

        /// <summary>
        /// <para>The list of actual field names referenced by the index, with prefix length expressions removed from ColumnNames.</para>
        /// </summary>
        [NameInMap("RealColumnNames")]
        [Validation(Required=false)]
        public List<string> RealColumnNames { get; set; }

        /// <summary>
        /// <para>Specifies whether the index is a unique index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Unique")]
        [Validation(Required=false)]
        public bool? Unique { get; set; }

    }

}
