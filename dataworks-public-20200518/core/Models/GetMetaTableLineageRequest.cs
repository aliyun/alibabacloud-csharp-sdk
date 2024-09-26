// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableLineageRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the E-MapReduce (EMR) cluster. Configure this parameter only if you want to query the lineage of an EMR table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values: odps and emr.</para>
        /// 
        /// <b>Example:</b>
        /// <para>emr</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>Specifies the ancestor or descendant lineage that you want to query for a field. Valid values: up and down. The value up indicates the ancestor lineage. The value down indicates the descendant lineage.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>up</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The logic of paging. Configure this parameter based on the value of the response parameter NextPrimaryKey when the value of the response parameter HasNext is true in the previous request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps.engine_name.table_name1</para>
        /// </summary>
        [NameInMap("NextPrimaryKey")]
        [Validation(Required=false)]
        public string NextPrimaryKey { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps.engine_name.table_name</para>
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
