// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ApplyNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed result of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Resources Application is satisfied. Creating...</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>The instance IDs.</para>
        /// <remarks>
        /// <para> AddNodes is an asynchronous API operation. If a request succeeds, a response is immediately generated before ECS instances are created. Therefore, the value of this parameter is null. You can call the <a href="https://help.aliyun.com/document_detail/87161.html">ListNodes</a> operation to query the IDs of the ECS instances.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public ApplyNodesResponseBodyInstanceIds InstanceIds { get; set; }
        public class ApplyNodesResponseBodyInstanceIds : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public List<string> InstanceId { get; set; }

        }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B745C159-3155-4B94-95D0-4B73D4D2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of the compute nodes that are created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SatisfiedAmount")]
        [Validation(Required=false)]
        public int? SatisfiedAmount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B745C159-3155-4B94-95D0-4B73D4D2****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
