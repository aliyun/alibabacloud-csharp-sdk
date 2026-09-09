// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateTaskAsyncResponseBody : TeaModel {
        /// <summary>
        /// <para>The operation ID, which is used to obtain the result of the asynchronous node update. You can call the UpdateTaskAsync operation to obtain the result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e15ad21c-b0e9-4792-8f55-b037xxxxxxxx</para>
        /// </summary>
        [NameInMap("OperationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// <para>The request ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
