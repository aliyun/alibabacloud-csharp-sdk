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
        /// <para>The username. Only RAM users and STS accounts are supported. If the account is a RAM user, the name must be prefixed with p4_, such as p4_234253434. If the account is an STS account, the name must be prefixed with v4_, such as v4_3234134.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p4_2346134</para>
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
