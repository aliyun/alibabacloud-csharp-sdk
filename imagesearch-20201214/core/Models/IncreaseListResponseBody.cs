// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class IncreaseListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public IncreaseListResponseBodyData Data { get; set; }
        public class IncreaseListResponseBodyData : TeaModel {
            [NameInMap("Increments")]
            [Validation(Required=false)]
            public IncreaseListResponseBodyDataIncrements Increments { get; set; }
            public class IncreaseListResponseBodyDataIncrements : TeaModel {
                [NameInMap("Instance")]
                [Validation(Required=false)]
                public List<IncreaseListResponseBodyDataIncrementsInstance> Instance { get; set; }
                public class IncreaseListResponseBodyDataIncrementsInstance : TeaModel {
                    [NameInMap("BucketName")]
                    [Validation(Required=false)]
                    public string BucketName { get; set; }

                    [NameInMap("CallbackAddress")]
                    [Validation(Required=false)]
                    public string CallbackAddress { get; set; }

                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("ErrorUrl")]
                    [Validation(Required=false)]
                    public string ErrorUrl { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Msg")]
                    [Validation(Required=false)]
                    public string Msg { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("UtcCreate")]
                    [Validation(Required=false)]
                    public string UtcCreate { get; set; }

                    [NameInMap("UtcModified")]
                    [Validation(Required=false)]
                    public long? UtcModified { get; set; }

                }

            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
