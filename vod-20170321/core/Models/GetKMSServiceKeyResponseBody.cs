// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetKMSServiceKeyResponseBody : TeaModel {
        [NameInMap("KmsKeyInfoList")]
        [Validation(Required=false)]
        public List<GetKMSServiceKeyResponseBodyKmsKeyInfoList> KmsKeyInfoList { get; set; }
        public class GetKMSServiceKeyResponseBodyKmsKeyInfoList : TeaModel {
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            [NameInMap("CreationDate")]
            [Validation(Required=false)]
            public string CreationDate { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("DeleteDate")]
            [Validation(Required=false)]
            public string DeleteDate { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            [NameInMap("KeyState")]
            [Validation(Required=false)]
            public string KeyState { get; set; }

            [NameInMap("KeyUsage")]
            [Validation(Required=false)]
            public string KeyUsage { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
