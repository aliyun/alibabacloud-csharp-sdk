// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class PutDisableFwSwitchResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether only a dry run was performed. If this parameter is true, the system performed pre-checks such as parameter validity, identity permissions, resource existence, quota limits, and dependency relationships without creating, updating, or deleting actual resources, triggering asynchronous traffic diversion tasks, or generating downstream side effects such as billing, notifications, or callbacks. If the dry run succeeded, DryRun=true is returned in the response, which can be distinguished from an actual call response. If the dry run failed, a machine-readable error code is returned (such as ErrorParamsInvalid for parameter errors, ErrorAuthentication for insufficient permissions, or ErrorInstanceOpenIpNumExceed for insufficient quota). A value of false (default) indicates that the request was initiated and the enable operation was performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B2841452-CB8D-4F7D-B247-38E1CF7334F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
