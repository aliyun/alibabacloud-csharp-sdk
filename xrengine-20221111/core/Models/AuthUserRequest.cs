// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20221111.Models
{
    public class AuthUserRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("JwtToken")]
        [Validation(Required=false)]
        public string JwtToken { get; set; }

    }

}
