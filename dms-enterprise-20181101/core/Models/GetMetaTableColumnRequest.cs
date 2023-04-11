// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetMetaTableColumnRequest : TeaModel {
        /// <summary>
        /// The globally unique identifier (GUID) of the table in Data Management (DMS).
        /// 
        /// *   If the database to which the table belongs is a logical database, you can call the [ListLogicTables](~~141875~~) operation to obtain the value of this parameter.
        /// *   If the database to which the table belongs is a physical database, you can call the [ListTables](~~141878~~) operation to obtain the value of this parameter.
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
