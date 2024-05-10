// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTaskErrorLogRequest : TeaModel {
        /// <summary>
        /// The ID of the task.
        /// 
        /// >  You can call the DescribeImageFixTask operation to query the IDs of tasks.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BuildTaskId")]
        [Validation(Required=false)]
        public string BuildTaskId { get; set; }

    }

}
