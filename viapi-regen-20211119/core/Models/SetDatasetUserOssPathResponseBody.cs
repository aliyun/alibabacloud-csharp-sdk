// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class SetDatasetUserOssPathResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SetDatasetUserOssPathResponseBodyData Data { get; set; }
        public class SetDatasetUserOssPathResponseBodyData : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("OssUrl")]
            [Validation(Required=false)]
            public string OssUrl { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
