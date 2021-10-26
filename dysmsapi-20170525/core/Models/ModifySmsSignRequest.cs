// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class ModifySmsSignRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SignFileList")]
        [Validation(Required=false)]
        public List<ModifySmsSignRequestSignFileList> SignFileList { get; set; }
        public class ModifySmsSignRequestSignFileList : TeaModel {
            [NameInMap("FileContents")]
            [Validation(Required=false)]
            public string FileContents { get; set; }

            [NameInMap("FileSuffix")]
            [Validation(Required=false)]
            public string FileSuffix { get; set; }

        }

        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        [NameInMap("SignSource")]
        [Validation(Required=false)]
        public int? SignSource { get; set; }

    }

}
