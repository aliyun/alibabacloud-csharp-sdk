// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CertConfig : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("certName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("privateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

    }

}
