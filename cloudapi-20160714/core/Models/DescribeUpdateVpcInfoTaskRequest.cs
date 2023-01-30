// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeUpdateVpcInfoTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the task.
        /// </summary>
        [NameInMap("OperationUid")]
        [Validation(Required=false)]
        public string OperationUid { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
