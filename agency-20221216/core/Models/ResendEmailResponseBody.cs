// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class ResendEmailResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code.
        /// Error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>200: OK.</description></item>
        /// <item><description>1109: System error.</description></item>
        /// <item><description>3058: Emails are sent too frequently. A maximum of 10 emails can be sent within 5 minutes.</description></item>
        /// <item><description>3057: InviteId is empty.</description></item>
        /// <item><description>3060: No sending record found for the specified InviteId.</description></item>
        /// <item><description>3061: The registration URL has expired and the email cannot be resent.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The result message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. A unique identifier that Alibaba Cloud generates for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Valid values: True/False. Indicates whether the current API call itself is successful. This does not indicate the success of subsequent business operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
