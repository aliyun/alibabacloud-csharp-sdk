// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateWorkflowInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the operation. You can use this field to query the results of the creation operation through the GetCreateWorkflowInstancesResult interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e15ad21c-b0e9-4792-8f55-b037xxxxxxxx</para>
        /// </summary>
        [NameInMap("OperationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// <para>The ID of the request. It is used to locate logs and troubleshoot problems.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77A17XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
