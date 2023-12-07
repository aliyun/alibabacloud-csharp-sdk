// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class RunApplicationActionResponseBody : TeaModel {
        /// <summary>
        /// 异常节点列表。
        /// </summary>
        [NameInMap("AbnInstances")]
        [Validation(Required=false)]
        public List<RunApplicationActionResponseBodyAbnInstances> AbnInstances { get; set; }
        public class RunApplicationActionResponseBodyAbnInstances : TeaModel {
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

        }

        /// <summary>
        /// The operation ID.
        /// </summary>
        [NameInMap("OperationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
