// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTableDBTopologyRequest : TeaModel {
        /// <summary>
        /// The GUID of the table in DMS.
        /// 
        /// > 
        /// 
        /// *   If the database to which the table belongs is a logical database, you can call the [ListLogicTables](~~141875~~) operation to obtain the GUID. The value of the ReturnGuid parameter must be set to true.
        /// 
        /// *   If the database to which the table belongs is a physical database, you can call the [ListTables](~~141878~~) operation to obtain the GUID. The value of the ReturnGuid parameter must be set to true.
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// > To view the tenant ID, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see [Manage DMS tenants](~~181330~~).
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
