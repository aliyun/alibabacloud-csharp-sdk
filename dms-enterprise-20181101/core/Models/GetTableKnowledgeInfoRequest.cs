// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTableKnowledgeInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the physical database. You can call the <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>325</para>
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public int? DbId { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_name</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The schema name of the table, which is required only for SQL Server instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbo</para>
        /// </summary>
        [NameInMap("TableSchemaName")]
        [Validation(Required=false)]
        public string TableSchemaName { get; set; }

    }

}
