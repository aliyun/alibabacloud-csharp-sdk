// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetMFAAuthenticationStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of MFA. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled</description></item>
        /// <item><description>Disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("MFAAuthenticationStatus")]
        [Validation(Required=false)]
        public string MFAAuthenticationStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5E688346-DF1A-5537-9BFC-8A9974D29586</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
