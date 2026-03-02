// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class LineageTable : TeaModel {
        /// <summary>
        /// <para>The information about columns.</para>
        /// </summary>
        [NameInMap("columns")]
        [Validation(Required=false)]
        public List<LineageColumn> Columns { get; set; }

        /// <summary>
        /// <para>The table ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>434508</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The information about the table. The information includes the user who creates the table, the user who modifies the table, and the creation time and modification time of the table.</para>
        /// </summary>
        [NameInMap("properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-test</para>
        /// </summary>
        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The parameters of the table.</para>
        /// </summary>
        [NameInMap("with")]
        [Validation(Required=false)]
        public Dictionary<string, object> With { get; set; }

    }

}
