// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class GetBindingErrorByTaskIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBindingErrorByTaskIdResponseBodyData Data { get; set; }
        public class GetBindingErrorByTaskIdResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("VoList")]
            [Validation(Required=false)]
            public GetBindingErrorByTaskIdResponseBodyDataVoList VoList { get; set; }
            public class GetBindingErrorByTaskIdResponseBodyDataVoList : TeaModel {
                [NameInMap("BindingErrorDO")]
                [Validation(Required=false)]
                public List<GetBindingErrorByTaskIdResponseBodyDataVoListBindingErrorDO> BindingErrorDO { get; set; }
                public class GetBindingErrorByTaskIdResponseBodyDataVoListBindingErrorDO : TeaModel {
                    [NameInMap("Destination")]
                    [Validation(Required=false)]
                    public string Destination { get; set; }

                    [NameInMap("DestinationType")]
                    [Validation(Required=false)]
                    public string DestinationType { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("RoutingKey")]
                    [Validation(Required=false)]
                    public string RoutingKey { get; set; }

                    [NameInMap("Src")]
                    [Validation(Required=false)]
                    public string Src { get; set; }

                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public long? TaskId { get; set; }

                    [NameInMap("VhostName")]
                    [Validation(Required=false)]
                    public string VhostName { get; set; }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
