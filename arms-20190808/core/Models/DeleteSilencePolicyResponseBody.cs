// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteSilencePolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the silence policy was deleted successfully. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The silence policy was deleted successfully.</description></item>
        /// <item><description><c>false</c>: The silence policy failed to be deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform. Set the value to <b>DeleteSilencePolicy</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5EC8221-08F2-4C95-9AF1-49FD998C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
