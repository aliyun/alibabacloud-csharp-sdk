// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ApplyNodesResponseBody : TeaModel {
        /// <summary>
        /// The detailed result of the request.
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public ApplyNodesResponseBodyInstanceIds InstanceIds { get; set; }
        public class ApplyNodesResponseBodyInstanceIds : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public List<string> InstanceId { get; set; }

        }

        /// <summary>
        /// The task ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of the compute nodes that are created.
        /// </summary>
        [NameInMap("SatisfiedAmount")]
        [Validation(Required=false)]
        public int? SatisfiedAmount { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
