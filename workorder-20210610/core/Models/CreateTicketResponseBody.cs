// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class CreateTicketResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the permission error. An empty string is returned if the permissions are sufficient.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;AuthAction\&quot;:\&quot;ram:CreateTicket\&quot;,\&quot;AuthPrincipalDisplayName\&quot;:\&quot;2146216584788xxxxx\&quot;,\&quot;AuthPrincipalOwnerId\&quot;:\&quot;1135850448xxxxx\&quot;,\&quot;AuthPrincipalType\&quot;:\&quot;SubUser\&quot;,\&quot;NoPermissionType\&quot;:\&quot;ImplicitDeny\&quot;,\&quot;PolicyType\&quot;:\&quot;AccountLevelIdentityBasedPolicy\&quot;}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The return code of the API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The return value, which is the ticket ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0005PYGCW</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is returned when the value of Success is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. Each request has a unique ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0254B7DE-7365-57B4-8E38-14FE927E3FEB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. A value of true indicates that the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
