// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class ReplyTicketResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information about the permission error. If you have the required permissions, an empty string is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;AuthAction\&quot;:\&quot;ram:ReplyTicket\&quot;,\&quot;AuthPrincipalDisplayName\&quot;:\&quot;2146216584788xxxxx\&quot;,\&quot;AuthPrincipalOwnerId\&quot;:\&quot;1135850448xxxxx\&quot;,\&quot;AuthPrincipalType\&quot;:\&quot;SubUser\&quot;,\&quot;NoPermissionType\&quot;:\&quot;ImplicitDeny\&quot;,\&quot;PolicyType\&quot;:\&quot;AccountLevelIdentityBasedPolicy\&quot;}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The dialog ID of the ticket reply.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46434030</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is returned when the value of Success is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid input parameters</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C1DA4C6F-963E-5741-AB57-67A554D102FD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
