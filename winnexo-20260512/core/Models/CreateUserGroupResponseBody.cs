// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateUserGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The newly created user group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;userGroupId&quot;:&quot;7ea8973f-7a5c-4e8a-956b-4fe0e7e2eb11&quot;,&quot;userGroupName&quot;:&quot;South China Sales&quot;,&quot;parentId&quot;:null,&quot;level&quot;:1,&quot;description&quot;:&quot;South China sales organization&quot;,&quot;childGroupCount&quot;:0,&quot;directMemberCount&quot;:0,&quot;sourceType&quot;:&quot;internal&quot;,&quot;externalSyncStatus&quot;:null,&quot;gmtCreate&quot;:&quot;2026-08-27T09:00:00Z&quot;,&quot;gmtModified&quot;:&quot;2026-08-27T09:00:00Z&quot;}</para>
        /// </summary>
        [NameInMap("userGroup")]
        [Validation(Required=false)]
        public object UserGroup { get; set; }

    }

}
