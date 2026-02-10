// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class KMSConfig : TeaModel {
        /// <summary>
        /// <para>The KMS instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>kst-xxxxxxxx</para>
        /// </summary>
        [NameInMap("kmsInstanceId")]
        [Validation(Required=false)]
        public string KmsInstanceId { get; set; }

        /// <summary>
        /// <para>The KMS key ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>key-xxxxxxxx</para>
        /// </summary>
        [NameInMap("kmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

    }

}
