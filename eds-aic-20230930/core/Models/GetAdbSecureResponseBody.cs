// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class GetAdbSecureResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAdbSecureResponseBodyData Data { get; set; }
        public class GetAdbSecureResponseBodyData : TeaModel {
            [NameInMap("AdbSecureList")]
            [Validation(Required=false)]
            public List<GetAdbSecureResponseBodyDataAdbSecureList> AdbSecureList { get; set; }
            public class GetAdbSecureResponseBodyDataAdbSecureList : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
