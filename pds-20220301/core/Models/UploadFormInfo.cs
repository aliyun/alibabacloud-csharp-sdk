// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UploadFormInfo : TeaModel {
        [NameInMap("bucket_name")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("form_data")]
        [Validation(Required=false)]
        public Dictionary<string, string> FormData { get; set; }

        [NameInMap("object_key")]
        [Validation(Required=false)]
        public string ObjectKey { get; set; }

        [NameInMap("oss_access_key_id")]
        [Validation(Required=false)]
        public string OssAccessKeyId { get; set; }

        [NameInMap("oss_end_point")]
        [Validation(Required=false)]
        public string OssEndPoint { get; set; }

        [NameInMap("oss_security_token")]
        [Validation(Required=false)]
        public string OssSecurityToken { get; set; }

        [NameInMap("policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

    }

}
