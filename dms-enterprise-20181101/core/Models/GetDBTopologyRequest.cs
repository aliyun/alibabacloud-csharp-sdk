// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDBTopologyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the logical database. You can call the <a href="https://www.alibabacloud.com/help/en/data-management-service/latest/listlogicdatabases">ListLogicDatabases</a> or <a href="https://www.alibabacloud.com/help/en/data-management-service/latest/searchdatabase">SearchDatabase</a> operation to query the ID of the logical database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>134***</para>
        /// </summary>
        [NameInMap("LogicDbId")]
        [Validation(Required=false)]
        public long? LogicDbId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para>To view the tenant ID, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see <a href="https://help.aliyun.com/document_detail/181330.html">Manage DMS tenants</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>43***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
