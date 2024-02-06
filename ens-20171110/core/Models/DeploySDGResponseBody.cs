// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeploySDGResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeploySDGResponseBodyData Data { get; set; }
        public class DeploySDGResponseBodyData : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public DeploySDGResponseBodyDataResult Result { get; set; }
            public class DeploySDGResponseBodyDataResult : TeaModel {
                [NameInMap("FailedCount")]
                [Validation(Required=false)]
                public long? FailedCount { get; set; }

                [NameInMap("FailedItems")]
                [Validation(Required=false)]
                public List<DeploySDGResponseBodyDataResultFailedItems> FailedItems { get; set; }
                public class DeploySDGResponseBodyDataResultFailedItems : TeaModel {
                    [NameInMap("ErrMessage")]
                    [Validation(Required=false)]
                    public string ErrMessage { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                }

                [NameInMap("SuccessCount")]
                [Validation(Required=false)]
                public long? SuccessCount { get; set; }

            }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
