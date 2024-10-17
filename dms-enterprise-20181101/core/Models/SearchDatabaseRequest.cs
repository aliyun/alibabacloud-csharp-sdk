// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SearchDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>The type of the database. For more information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/198106.html">DbType parameter</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MYSQL</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The environment type of the database. For more information, see <a href="https://help.aliyun.com/document_detail/163309.html">Change the environment type of an instance</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
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
        /// <para>The keyword that is used to search for databases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The query range based on permissions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HAS_PERMSSION</b>: searches for databases on which the current user has permissions.</description></item>
        /// <item><description><b>OWNER</b>: searches for databases owned by the current user.</description></item>
        /// <item><description><b>MY_FOCUS</b>: searches for databases that the current user follows.</description></item>
        /// <item><description><b>UNKNOWN</b>: searches for all databases.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HAS_PERMSSION</para>
        /// </summary>
        [NameInMap("SearchRange")]
        [Validation(Required=false)]
        public string SearchRange { get; set; }

        /// <summary>
        /// <para>The category of the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DB</b>: single database or logical database.</description></item>
        /// <item><description><b>SINGLE_DB</b>: single database.</description></item>
        /// <item><description><b>LOGIC_DB</b>: logical database.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SINGLE_DB</para>
        /// </summary>
        [NameInMap("SearchTarget")]
        [Validation(Required=false)]
        public string SearchTarget { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> operation to query the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
