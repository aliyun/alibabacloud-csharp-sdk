// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class TLSConfig : TeaModel {
        /// <summary>
        /// TLS加密套件列表
        /// </summary>
        [NameInMap("cipherSuites")]
        [Validation(Required=false)]
        public List<string> CipherSuites { get; set; }

        /// <summary>
        /// TLS最小版本号
        /// </summary>
        [NameInMap("minVersion")]
        [Validation(Required=false)]
        public string MinVersion { get; set; }

    }

}
