// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DeleteDataSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID. You can locate logs and troubleshoot issues based on the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B56432E0-2112-5C97-88D0-AA0AE5C75C74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the call is successful.</para>
        /// <list type="bullet">
        /// <item><description>true: Successful</description></item>
        /// <item><description>false: Failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
