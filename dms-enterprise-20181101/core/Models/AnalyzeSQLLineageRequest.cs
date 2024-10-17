// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AnalyzeSQLLineageRequest : TeaModel {
        /// <summary>
        /// <para>The database ID.</para>
        /// <remarks>
        /// <para> You can call one of the <a href="https://help.aliyun.com/document_detail/141876.html">SearchDatabase</a>, <a href="https://help.aliyun.com/document_detail/141873.html">ListDatabases</a>, and <a href="https://help.aliyun.com/document_detail/141869.html">GetDatabase</a> operations to obtain the database ID provided in the DatabaseId response parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123***</para>
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        /// <summary>
        /// <para>The SQL statement.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>insert into a (id) select id from b;</para>
        /// </summary>
        [NameInMap("SqlContent")]
        [Validation(Required=false)]
        public string SqlContent { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <remarks>
        /// <para> To view the tenant ID, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see <a href="https://help.aliyun.com/document_detail/181330.html">Manage DMS tenants</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
