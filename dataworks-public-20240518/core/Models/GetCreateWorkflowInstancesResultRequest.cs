// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetCreateWorkflowInstancesResultRequest : TeaModel {
        /// <summary>
        /// <para>The operation ID. This parameter is used to query the result of asynchronously creating a workflow instance. You can call the CreateWorkflowInstances operation to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e15ad21c-b0e9-4792-8f55-b037xxxxxxxx</para>
        /// </summary>
        [NameInMap("OperationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

    }

}
