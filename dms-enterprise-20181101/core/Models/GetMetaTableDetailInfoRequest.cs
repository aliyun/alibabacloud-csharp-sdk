// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetMetaTableDetailInfoRequest : TeaModel {
        /// <summary>
        /// The GUID of the table in Data Management (DMS).
        /// 
        /// > 
        /// 
        /// *   You can call the [ListLogicTables](~~141875~~) operation with ReturnGuid set to true to query the GUIDs of logical tables in a specific logical database.
        /// 
        /// *   You can call the [ListTables](~~141878~~) operation with ReturnGuid set to true to query the GUIDs of tables in a specific physical database.
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// > To view the ID of the tenant, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see the [View information about the current tenant](~~181330~~) section of the Manage DMS tenants topic.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
