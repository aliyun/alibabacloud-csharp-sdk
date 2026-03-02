// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListAccessKeysInRecycleBinResponseBody : TeaModel {
        [NameInMap("AccessKeys")]
        [Validation(Required=false)]
        public ListAccessKeysInRecycleBinResponseBodyAccessKeys AccessKeys { get; set; }
        public class ListAccessKeysInRecycleBinResponseBodyAccessKeys : TeaModel {
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public List<ListAccessKeysInRecycleBinResponseBodyAccessKeysAccessKey> AccessKey { get; set; }
            public class ListAccessKeysInRecycleBinResponseBodyAccessKeysAccessKey : TeaModel {
                [NameInMap("AccessKeyId")]
                [Validation(Required=false)]
                public string AccessKeyId { get; set; }

                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("DeleteDate")]
                [Validation(Required=false)]
                public string DeleteDate { get; set; }

                [NameInMap("RecycleDate")]
                [Validation(Required=false)]
                public string RecycleDate { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
