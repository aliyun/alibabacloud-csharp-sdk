// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The encryption setting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PlainText: The value is in plaintext.</para>
        /// </description></item>
        /// <item><description><para>Secret: The value is in ciphertext.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("EncryptOption")]
        [Validation(Required=false)]
        public string EncryptOption { get; set; }

    }

}
