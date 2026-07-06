// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateRepoSyncTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Return value</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the invocation succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The invocation succeeded.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Failed to invoke.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F8A0BA6-7F06-4BAE-B147-10BD6A25****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Sync task ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>rst-gbch330f0c****</para>
        /// </summary>
        [NameInMap("SyncTaskId")]
        [Validation(Required=false)]
        public string SyncTaskId { get; set; }

    }

}
