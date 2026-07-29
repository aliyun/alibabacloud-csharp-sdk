// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class CreateUserRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the user is a superuser.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("superUser")]
        [Validation(Required=false)]
        public bool? SuperUser { get; set; }

        /// <summary>
        /// <para>The user name. Only RAM users and STS accounts are supported. The user name must be prefixed with &quot;p4_&quot; for RAM users (e.g., p4_234253434) and &quot;v4_&quot; for STS accounts (e.g., v4_3234134).</para>
        /// 
        /// <b>Example:</b>
        /// <para>p4_2346134</para>
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
