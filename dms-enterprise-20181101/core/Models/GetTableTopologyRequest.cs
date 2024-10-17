// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTableTopologyRequest : TeaModel {
        /// <summary>
        /// <para>The GUID of the table in Data Management (DMS).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/141875.html">ListLogicTables</a> operation with ReturnGuid set to true to query the GUIDs of logical tables in a specific logical database.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/141878.html">ListTables</a> operation with ReturnGuid set to true to query the GUIDs of tables in a specific physical database.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IDB_L_308302.yuyang_test.test_ch</para>
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para>To view the ID of the tenant, move the pointer over the profile picture in the upper-right corner of the DMS console. For more information, see the &quot;View information about the current tenant&quot; section of the <a href="https://help.aliyun.com/document_detail/181330.html">Tenant information</a> topic.</para>
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
