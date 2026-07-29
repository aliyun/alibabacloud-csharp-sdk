// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class DropUserRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the user is a superuser.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("superUser")]
        [Validation(Required=false)]
        public string SuperUser { get; set; }

        /// <summary>
        /// <para>The user name. Only RAM users and STS accounts are supported. Prefix the name with &quot;p4_&quot; for a RAM user (for example, p4_234253434) or &quot;v4_&quot; for an STS account (for example, v4_3234134).</para>
        /// 
        /// <b>Example:</b>
        /// <para>p4_234253434</para>
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
