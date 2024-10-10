// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class GetUserGroupInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the user group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The user group modifier. The UserID of the Quick BI is used instead of the UID of Alibaba Cloud.</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

    }

}
