// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class StateChangeReason : TeaModel {
        /// <summary>
        /// <para>The status code. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><para>UserRequest: The state change was initiated by the user.</para>
        /// </description></item>
        /// <item><description><para>QuotaExceeded: A service or resource quota was exceeded.</para>
        /// </description></item>
        /// <item><description><para>InternalError: An internal error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MissingParameter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A message providing additional details about the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The instance type is required.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
