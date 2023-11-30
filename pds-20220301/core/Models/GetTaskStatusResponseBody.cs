// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetTaskStatusResponseBody : TeaModel {
        /// <summary>
        /// The state of the task.
        /// 
        /// Valid values:
        /// 
        /// *   running
        /// 
        ///     <!-- -->
        /// 
        ///     : The task is
        /// 
        ///     <!-- -->
        /// 
        ///     running
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// 
        /// *   failed
        /// 
        ///     <!-- -->
        /// 
        ///     : The task
        /// 
        ///     <!-- -->
        /// 
        ///     fails
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// 
        /// *   succeeded
        /// 
        ///     <!-- -->
        /// 
        ///     : The task is
        /// 
        ///     <!-- -->
        /// 
        ///     successful
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
