// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetApplicationInstanceListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetApplicationInstanceListResponseBodyData Data { get; set; }
        public class GetApplicationInstanceListResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GetApplicationInstanceListResponseBodyDataResult> Result { get; set; }
            public class GetApplicationInstanceListResponseBodyDataResult : TeaModel {
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<GetApplicationInstanceListResponseBodyDataResultTags> Tags { get; set; }
                public class GetApplicationInstanceListResponseBodyDataResultTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                }

            }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

    }

}
