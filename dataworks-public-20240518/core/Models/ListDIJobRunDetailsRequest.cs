// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDIJobRunDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the synchronization task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11265</para>
        /// </summary>
        [NameInMap("DIJobId")]
        [Validation(Required=false)]
        public long? DIJobId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds_name</para>
        /// </summary>
        [NameInMap("SourceDataSourceName")]
        [Validation(Required=false)]
        public string SourceDataSourceName { get; set; }

        /// <summary>
        /// <para>The name of the database in the source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db_name</para>
        /// </summary>
        [NameInMap("SourceDatabaseName")]
        [Validation(Required=false)]
        public string SourceDatabaseName { get; set; }

        /// <summary>
        /// <para>The name of the schema of the source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>schema_name</para>
        /// </summary>
        [NameInMap("SourceSchemaName")]
        [Validation(Required=false)]
        public string SourceSchemaName { get; set; }

        /// <summary>
        /// <para>The name of the table in the source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_name</para>
        /// </summary>
        [NameInMap("SourceTableName")]
        [Validation(Required=false)]
        public string SourceTableName { get; set; }

    }

}
