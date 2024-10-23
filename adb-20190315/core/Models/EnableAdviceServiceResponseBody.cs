// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class EnableAdviceServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The message returned for the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Success</b> is returned if the operation is successful.</description></item>
        /// <item><description>An error message is returned if the operation fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1745C03-7CCE-55CF-932E-08121AAFA6AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
