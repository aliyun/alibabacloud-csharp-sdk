// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DataExtraInfoSubCondsValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>tenant_name</para>
        /// </summary>
        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>db_name</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dest_db</para>
        /// </summary>
        [NameInMap("DestDatabase")]
        [Validation(Required=false)]
        public string DestDatabase { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>table_name</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dest_name</para>
        /// </summary>
        [NameInMap("DestName")]
        [Validation(Required=false)]
        public string DestName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>id&gt;1</para>
        /// </summary>
        [NameInMap("WhereClause")]
        [Validation(Required=false)]
        public string WhereClause { get; set; }

        [NameInMap("FilterColumns")]
        [Validation(Required=false)]
        public List<string> FilterColumns { get; set; }

        [NameInMap("ShardColumns")]
        [Validation(Required=false)]
        public List<string> ShardColumns { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("LogicTableId")]
        [Validation(Required=false)]
        public string LogicTableId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("SourceEndpointId")]
        [Validation(Required=false)]
        public string SourceEndpointId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("SourceClientId")]
        [Validation(Required=false)]
        public string SourceClientId { get; set; }

    }

}
