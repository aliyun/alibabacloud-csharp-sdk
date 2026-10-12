// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateDeveloperRequest : TeaModel {
        /// <summary>
        /// <para>The password of the developer account. The length must be 6 to 32 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcd1234</para>
        /// </summary>
        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The logon username of the developer. The length must not exceed 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>developer-demo</para>
        /// </summary>
        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
