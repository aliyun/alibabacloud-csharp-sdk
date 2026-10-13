// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class EvaluateTicketResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the permission error. An empty string is returned if you have the required permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;AuthAction\&quot;:\&quot;ram:EvaluateTicket\&quot;,\&quot;AuthPrincipalDisplayName\&quot;:\&quot;2146216584788xxxxx\&quot;,\&quot;AuthPrincipalOwnerId\&quot;:\&quot;1135850448xxxxx\&quot;,\&quot;AuthPrincipalType\&quot;:\&quot;SubUser\&quot;,\&quot;NoPermissionType\&quot;:\&quot;ImplicitDeny\&quot;,\&quot;PolicyType\&quot;:\&quot;AccountLevelIdentityBasedPolicy\&quot;}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is returned only when the \<c>Success\\</c> parameter is \<c>false\\</c>.</para>
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
        /// <para>C1DA4C6F-963E-5741-AB57-67A554D102FD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. A value of \<c>true\\</c> indicates that the call succeeded. A value of \<c>false\\</c> indicates that the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
