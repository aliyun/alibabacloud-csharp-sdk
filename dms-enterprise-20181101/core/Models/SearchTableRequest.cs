// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SearchTableRequest : TeaModel {
        /// <summary>
        /// <para>The type of database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>SQLServer</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>Oracle</b></description></item>
        /// <item><description><b>DRDS</b></description></item>
        /// <item><description><b>OceanBase</b></description></item>
        /// <item><description><b>Mongo</b></description></item>
        /// <item><description><b>Redis</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The type of the environment to which databases belong. For more information, see <a href="https://help.aliyun.com/document_detail/163309.html">Change the environment type of an instance</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRODUCT</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the GUID of each table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ReturnGuid")]
        [Validation(Required=false)]
        public bool? ReturnGuid { get; set; }

        /// <summary>
        /// <para>The keyword that is used to query tables.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The scope of tables that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HAS_PERMSSION</b>: the tables on which the current account has permissions.</description></item>
        /// <item><description><b>OWNER</b>: the tables owned by the current account.</description></item>
        /// <item><description><b>MY_FOCUS</b>: the tables that the current account follows.</description></item>
        /// <item><description><b>UNKNOWN</b>: all tables.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OWNER</para>
        /// </summary>
        [NameInMap("SearchRange")]
        [Validation(Required=false)]
        public string SearchRange { get; set; }

        /// <summary>
        /// <para>The type of table that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TABLE</b>: physical and logical tables</description></item>
        /// <item><description><b>SINGLE_TABLE</b>: physical tables</description></item>
        /// <item><description><b>LOGIC_TABLE</b>: logical tables</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LOGIC_TABLE</para>
        /// </summary>
        [NameInMap("SearchTarget")]
        [Validation(Required=false)]
        public string SearchTarget { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para>To view the tenant ID, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see the <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a> section of the &quot;Manage DMS tenants&quot; topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
