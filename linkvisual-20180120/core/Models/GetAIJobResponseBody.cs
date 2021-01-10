// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class GetAIJobResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAIJobResponseBodyData Data { get; set; }
        public class GetAIJobResponseBodyData : TeaModel {
            [NameInMap("DataDTOList")]
            [Validation(Required=false)]
            public List<GetAIJobResponseBodyDataDataDTOList> DataDTOList { get; set; }
            public class GetAIJobResponseBodyDataDataDTOList : TeaModel {
                public string DataId { get; set; }
                public string DataType { get; set; }
                public string DataSource { get; set; }
                public string AlgoData { get; set; }
                public string JobId { get; set; }
                public string IotId { get; set; }
            }
            [NameInMap("ActionJobDTO")]
            [Validation(Required=false)]
            public GetAIJobResponseBodyDataActionJobDTO ActionJobDTO { get; set; }
            public class GetAIJobResponseBodyDataActionJobDTO : TeaModel {
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("ActionId")]
                [Validation(Required=false)]
                public string ActionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("IotId")]
                [Validation(Required=false)]
                public string IotId { get; set; }

            }
        };

    }

}
