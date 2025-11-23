// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AddTableToCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the associated category.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000254257</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// <para>The ID of a physical database: You can call the <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a> or <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a> operation to obtain the physical database ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1930****</para>
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        /// <summary>
        /// <para>The name of the table. You can call the <a href="https://help.aliyun.com/document_detail/141878.html">ListTables</a> operation to query the table name.</para>
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

        /// <summary>
        /// <para>The tenant ID. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> or <a href="https://help.aliyun.com/document_detail/198074.html">ListUserTenants</a> operation to obtain the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
