// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckProcessRequest : TeaModel {
        /// <summary>
        /// The ID of the task.
        /// 
        /// > You can call the [SubmitCheck](~~SubmitCheck~~) operation to query the ID.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
