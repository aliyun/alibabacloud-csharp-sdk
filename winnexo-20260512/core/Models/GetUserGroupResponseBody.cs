// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetUserGroupResponseBody : TeaModel {
        /// <summary>
        /// <para><b>The list of direct child user groups.</b></para>
        /// </summary>
        [NameInMap("childGroups")]
        [Validation(Required=false)]
        public List<object> ChildGroups { get; set; }

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
        /// <para><b>The list of direct members in the current user group.</b></para>
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<object> Members { get; set; }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para><b>The parent user group information. This is empty for the root node.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;userGroupId&quot;:&quot;b07fb0a4-0b7d-44a7-a3d5-a43a5964c8f0&quot;,&quot;userGroupName&quot;:&quot;Sales Center&quot;,&quot;parentId&quot;:null,&quot;level&quot;:1,&quot;description&quot;:&quot;Sales organization&quot;,&quot;childGroupCount&quot;:1,&quot;directMemberCount&quot;:0,&quot;sourceType&quot;:&quot;internal&quot;,&quot;externalSyncStatus&quot;:null,&quot;gmtCreate&quot;:&quot;2026-08-27T08:00:00Z&quot;,&quot;gmtModified&quot;:&quot;2026-08-27T08:00:00Z&quot;}</para>
        /// </summary>
        [NameInMap("parentGroup")]
        [Validation(Required=false)]
        public object ParentGroup { get; set; }

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
        /// <para><b>The target user group information.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;userGroupId&quot;:&quot;7ea8973f-7a5c-4e8a-956b-4fe0e7e2eb11&quot;,&quot;userGroupName&quot;:&quot;South China Sales&quot;,&quot;parentId&quot;:&quot;b07fb0a4-0b7d-44a7-a3d5-a43a5964c8f0&quot;,&quot;level&quot;:2,&quot;description&quot;:&quot;South China Sales organization&quot;,&quot;childGroupCount&quot;:0,&quot;directMemberCount&quot;:2,&quot;sourceType&quot;:&quot;internal&quot;,&quot;externalSyncStatus&quot;:null,&quot;gmtCreate&quot;:&quot;2026-08-27T09:00:00Z&quot;,&quot;gmtModified&quot;:&quot;2026-08-27T10:00:00Z&quot;}</para>
        /// </summary>
        [NameInMap("userGroup")]
        [Validation(Required=false)]
        public object UserGroup { get; set; }

    }

}
