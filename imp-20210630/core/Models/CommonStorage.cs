// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class CommonStorage : TeaModel {
        /// <summary>
        /// OSS bucket
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// OSS object path
        /// </summary>
        [NameInMap("Object")]
        [Validation(Required=false)]
        public string Object { get; set; }

        /// <summary>
        /// 阿里云Region，比如 cn-shanghai
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// OSS的签名URL
        /// </summary>
        [NameInMap("SignUrl")]
        [Validation(Required=false)]
        public string SignUrl { get; set; }

        /// <summary>
        /// Security Token Service
        /// </summary>
        [NameInMap("Sts")]
        [Validation(Required=false)]
        public CommonSTS Sts { get; set; }

    }

}
