// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class WithdrawAllUserGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the user. The UserID of the Quick BI is used instead of the UID of Alibaba Cloud.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46e5374665ba4b679ee22e2a2927****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
