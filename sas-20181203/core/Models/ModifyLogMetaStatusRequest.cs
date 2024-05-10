// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyLogMetaStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the request source. Set the value to **sas**.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The name of the dedicated Logstore in which logs are stored.
        /// 
        /// >  You can call the [DescribeLogMeta](~~DescribeLogMeta~~) operation to query the names of Logstores.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LogStore")]
        [Validation(Required=false)]
        public string LogStore { get; set; }

        /// <summary>
        /// The name of the project.
        /// 
        /// >  You can call the [DescribeLogMeta](~~DescribeLogMeta~~) operation to query the names of projects.
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// The status of the log analysis feature. Valid values:
        /// 
        /// *   **enabled**
        /// *   **disabled**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
