// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetCreateWorkflowInstancesResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77A17XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetCreateWorkflowInstancesResultResponseBodyResult Result { get; set; }
        public class GetCreateWorkflowInstancesResultResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Invalid Param xxx</para>
            /// </summary>
            [NameInMap("FailureMessage")]
            [Validation(Required=false)]
            public string FailureMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("WorkflowInstanceIds")]
            [Validation(Required=false)]
            public List<long?> WorkflowInstanceIds { get; set; }

        }

    }

}
