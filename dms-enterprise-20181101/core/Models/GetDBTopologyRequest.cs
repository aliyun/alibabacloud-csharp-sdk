// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDBTopologyRequest : TeaModel {
        /// <summary>
        /// The ID of the logical database.
        /// 
        /// > You can call the [ListLogicDatabases](~~141874~~) operation to query the ID of the logical database.
        /// </summary>
        [NameInMap("LogicDbId")]
        [Validation(Required=false)]
        public long? LogicDbId { get; set; }

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
