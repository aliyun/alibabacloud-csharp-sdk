// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryDiscoverDatabaseRequest : TeaModel {
        /// <summary>
        /// The ID of the scan task.
        /// 
        /// > You can call the [StartDiscoverDatabaseTask](~~StartDiscoverDatabaseTask~~) operation to query the ID of the task.
        /// </summary>
        [NameInMap("CreateMark")]
        [Validation(Required=false)]
        public string CreateMark { get; set; }

    }

}
