// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class AddUserGroupMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of user group member relationships that were actually added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("affectedCount")]
        [Validation(Required=false)]
        public long? AffectedCount { get; set; }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of requested members before deduplication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("requestedCount")]
        [Validation(Required=false)]
        public long? RequestedCount { get; set; }

        /// <summary>
        /// <para>The ID of the target user group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7ea8973f-7a5c-4e8a-956b-4fe0e7e2eb11</para>
        /// </summary>
        [NameInMap("userGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

    }

}
