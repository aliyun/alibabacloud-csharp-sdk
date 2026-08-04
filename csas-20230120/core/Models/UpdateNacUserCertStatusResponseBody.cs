// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateNacUserCertStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code or POP error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: Success.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: Redirection.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: Client error.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: Server error.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Additional information about the result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102350E7-1A20-58F5-9D63-ABEA820AE6E1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
