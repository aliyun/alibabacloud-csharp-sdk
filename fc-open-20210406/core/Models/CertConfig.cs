// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CertConfig : TeaModel {
        /// <summary>
        /// 证书名称
        /// </summary>
        [NameInMap("certName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// 证书，如果是证书链则依次填写多个证书
        /// </summary>
        [NameInMap("certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// 私钥
        /// </summary>
        [NameInMap("privateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

    }

}
