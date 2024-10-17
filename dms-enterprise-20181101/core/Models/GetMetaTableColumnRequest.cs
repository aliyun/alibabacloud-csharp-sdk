// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetMetaTableColumnRequest : TeaModel {
        /// <summary>
        /// <para>The globally unique identifier (GUID) of the table in Data Management (DMS).</para>
        /// <list type="bullet">
        /// <item><description>If the database to which the table belongs is a logical database, you can call the <a href="https://help.aliyun.com/document_detail/141875.html">ListLogicTables</a> operation to obtain the value of this parameter.</description></item>
        /// <item><description>If the database to which the table belongs is a physical database, you can call the <a href="https://help.aliyun.com/document_detail/141878.html">ListTables</a> operation to obtain the value of this parameter.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IDB_40753****.qntest2.activity_setting</para>
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> operation to obtain the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
