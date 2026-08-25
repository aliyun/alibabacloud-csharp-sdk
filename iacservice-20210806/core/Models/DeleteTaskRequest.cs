// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class DeleteTaskRequest : TeaModel {
        /// <summary>
        /// <para>The data retention policy. If this parameter is not specified, the policy is unconfirmed. If the node has resources or the resource status is unknown, the operation returns a confirmation fault. Set this parameter to RETAIN to delete only the node management record and retain the cloud resources.</para>
        /// </summary>
        [NameInMap("resourceRetentionPolicy")]
        [Validation(Required=false)]
        public string ResourceRetentionPolicy { get; set; }

    }

}
