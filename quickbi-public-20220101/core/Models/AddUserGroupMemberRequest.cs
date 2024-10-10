// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddUserGroupMemberRequest : TeaModel {
        /// <summary>
        /// <para>The result of adding members to a user group is returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The task is added.</description></item>
        /// <item><description>false: The tag failed to be added.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>555c4cd****</para>
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46e537a5****,3dadsu****</para>
        /// </summary>
        [NameInMap("UserIdList")]
        [Validation(Required=false)]
        public string UserIdList { get; set; }

    }

}
