// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class ApplyAdviceByIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Returns <b>SUCCESS</b> if the request is successful.</para>
        /// </description></item>
        /// <item><description><para>Returns an error message if the request fails.</para>
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
        /// <para>5DC10091-348D-12B1-906D-AB49D658012E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
