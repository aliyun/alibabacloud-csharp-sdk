// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class EncryptPasswordResponseBody : TeaModel {
        /// <summary>
        /// <para>The encrypted password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d34601bc-e6b1-4433-b0cc-8f6c5e52;n4apvGub3OBoj4Grwg==;thhO4UEomJfdvwnwlA==</para>
        /// </summary>
        [NameInMap("EncryptedPassword")]
        [Validation(Required=false)]
        public string EncryptedPassword { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AF538DA8-FFC6-52DA-8FF8-7B92579F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
