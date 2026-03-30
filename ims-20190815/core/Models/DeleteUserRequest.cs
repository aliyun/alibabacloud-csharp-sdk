// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class DeleteUserRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the RAM user.</para>
        /// <remarks>
        /// <para> You must specify only one of the following parameters: <c>UserPrincipalName</c> and <c>UserId</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20732900249392****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The logon name of the RAM user.</para>
        /// <remarks>
        /// <para> You must specify only one of the following parameters: <c>UserPrincipalName</c> and <c>UserId</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
        /// </summary>
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
