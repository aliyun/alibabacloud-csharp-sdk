// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class TLSConfig : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("cipherSuites")]
        [Validation(Required=false)]
        public List<string> CipherSuites { get; set; }

        [NameInMap("maxVersion")]
        [Validation(Required=false)]
        public string MaxVersion { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("minVersion")]
        [Validation(Required=false)]
        public string MinVersion { get; set; }

    }

}
