// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTableDBTopologyRequest : TeaModel {
        /// <summary>
        /// <para>The GUID of the table in DMS.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If the database to which the table belongs is a logical database, you can call the <a href="https://help.aliyun.com/document_detail/141875.html">ListLogicTables</a> operation to obtain the GUID. The value of the ReturnGuid parameter must be set to true.</para>
        /// </description></item>
        /// <item><description><para>If the database to which the table belongs is a physical database, you can call the <a href="https://help.aliyun.com/document_detail/141878.html">ListTables</a> operation to obtain the GUID. The value of the ReturnGuid parameter must be set to true.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IDB_L_9032.db-test.yuyang_test</para>
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para>To view the tenant ID, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see <a href="https://help.aliyun.com/document_detail/181330.html">Manage DMS tenants</a>.</para>
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
