// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class BatchApplyAdviceByIdListResponseBody : TeaModel {
        /// <summary>
        /// <para>The message returned for the request.</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, <b>SUCCESS</b> is returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, an error message is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86F92D26-B774-5FA1-8E53-82CBEEEBB012</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
