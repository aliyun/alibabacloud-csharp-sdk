// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetOnlineDDLProgressRequest : TeaModel {
        /// <summary>
        /// The ID of the OnlineDDL SQL task details. You can call the [ListDBTaskSQLJobDetail](~~207073~~) operation to obtain the task detail ID.
        /// </summary>
        [NameInMap("JobDetailId")]
        [Validation(Required=false)]
        public long? JobDetailId { get; set; }

        /// <summary>
        /// The ID of the tenant.
        /// 
        /// > To view the ID of the tenant, go to the Data Management (DMS) console and move the pointer over the profile picture in the upper-right corner. For more information, see the "View information about the current tenant" section of the [Manage DMS tenants](~~181330~~) topic.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
