// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Id2MetaVerifyWithOCRRequest : TeaModel {
        [NameInMap("CertFile")]
        [Validation(Required=false)]
        public string CertFile { get; set; }

        [NameInMap("CertNationalFile")]
        [Validation(Required=false)]
        public string CertNationalFile { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com/cert.jpeg">https://www.aliyun.com/cert.jpeg</a></para>
        /// </summary>
        [NameInMap("CertNationalUrl")]
        [Validation(Required=false)]
        public string CertNationalUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com/cert.jpeg">https://www.aliyun.com/cert.jpeg</a></para>
        /// </summary>
        [NameInMap("CertUrl")]
        [Validation(Required=false)]
        public string CertUrl { get; set; }

    }

}
