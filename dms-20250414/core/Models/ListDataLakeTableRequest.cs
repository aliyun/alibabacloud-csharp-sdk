// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataLakeTableRequest : TeaModel {
        /// <summary>
        /// <para>The name of the data catalog.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hive</para>
        /// </summary>
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The maximum value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page of results. To retrieve the next page, set this parameter to the \<c>NextToken\\</c> value from the previous response. If you do not specify this parameter, the first page is returned.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>NextToken</b> is empty, there are no more queries.</para>
        /// </description></item>
        /// <item><description><para>If <b>NextToken</b> has a value, the value is the token to start the next query.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>f056501ada12****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The name of the metadata table. This parameter supports regular expressions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>.*</para>
        /// </summary>
        [NameInMap("TableNamePattern")]
        [Validation(Required=false)]
        public string TableNamePattern { get; set; }

        /// <summary>
        /// <para>The type of the table. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>MANAGED_TABLE: Internal table.</para>
        /// </description></item>
        /// <item><description><para>EXTERNAL_TABLE: External table.</para>
        /// </description></item>
        /// <item><description><para>VIRTUAL_VIEW: Virtual view.</para>
        /// </description></item>
        /// <item><description><para>INDEX_TABLE: Index table.</para>
        /// </description></item>
        /// <item><description><para>MATERIALIZED_VIEW: Materialized view.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MANAGED_TABLE</para>
        /// </summary>
        [NameInMap("TableType")]
        [Validation(Required=false)]
        public string TableType { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <remarks>
        /// <para>Hover over your profile picture in the upper-right corner of the DMS console to obtain the tenant ID. For details, see <a href="https://help.aliyun.com/document_detail/181330.html">View tenant information</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3****</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public long? WorkspaceId { get; set; }

    }

}
