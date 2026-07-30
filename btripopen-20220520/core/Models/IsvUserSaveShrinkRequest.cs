// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IsvUserSaveShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of employee information.</para>
        /// <list type="bullet">
        /// <item><description>The maximum number of employees per request is 100.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("user_list")]
        [Validation(Required=false)]
        public string UserListShrink { get; set; }

    }

}
