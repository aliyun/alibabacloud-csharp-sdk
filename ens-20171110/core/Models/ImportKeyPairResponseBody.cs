// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ImportKeyPairResponseBody : TeaModel {
        /// <summary>
        /// <para>The fingerprint of the key pair. The message-digest algorithm 5 (MD5) is used based on the public key fingerprint format defined in RFC 4716.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fdaf8ff7a756ef843814fc****</para>
        /// </summary>
        [NameInMap("KeyPairFingerPrint")]
        [Validation(Required=false)]
        public string KeyPairFingerPrint { get; set; }

        /// <summary>
        /// <para>The name of the key pair.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestKeyPairName</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
