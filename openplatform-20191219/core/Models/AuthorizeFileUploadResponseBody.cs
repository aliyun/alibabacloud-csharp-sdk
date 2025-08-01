// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenPlatform20191219.Models
{
    public class AuthorizeFileUploadResponseBody : TeaModel {
        [NameInMap("AccessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        [NameInMap("EncodedPolicy")]
        [Validation(Required=false)]
        public string EncodedPolicy { get; set; }

        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("ObjectKey")]
        [Validation(Required=false)]
        public string ObjectKey { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        [NameInMap("UseAccelerate")]
        [Validation(Required=false)]
        public bool? UseAccelerate { get; set; }

    }

}
