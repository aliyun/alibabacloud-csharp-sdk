// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryPreCheckDatabaseRequest : TeaModel {
        /// <summary>
        /// The UUID of the agent that is used to back up the data of the database.
        /// 
        /// > You can call the [DescribeUniBackupDatabase](~~DescribeUniBackupDatabase~~) operation to query the UUID.
        /// </summary>
        [NameInMap("InstanceUuid")]
        [Validation(Required=false)]
        public string InstanceUuid { get; set; }

        /// <summary>
        /// The ID of the database precheck task.
        /// 
        /// > You can call the [StartPreCheckDatabase](~~StartPreCheckDatabase~~) operation to query the ID of the database precheck task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The region ID of the server that hosts the database.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UniRegionId")]
        [Validation(Required=false)]
        public string UniRegionId { get; set; }

    }

}
