// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class CreateWorkflowResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateWorkflowResponseBodyData Data { get; set; }
        public class CreateWorkflowResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>w-acfmv4opbs****</para>
            /// </summary>
            [NameInMap("workflowId")]
            [Validation(Required=false)]
            public string WorkflowId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E3A7161-EB7B-172B-8D18-FFB06BA38***</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
