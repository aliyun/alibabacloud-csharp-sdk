// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class GetAIActionConfigResponseBody : TeaModel {
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
        public GetAIActionConfigResponseBodyData Data { get; set; }
        public class GetAIActionConfigResponseBodyData : TeaModel {
            [NameInMap("AlgoAction")]
            [Validation(Required=false)]
            public string AlgoAction { get; set; }
            [NameInMap("Des")]
            [Validation(Required=false)]
            public string Des { get; set; }
            [NameInMap("NeedDevice")]
            [Validation(Required=false)]
            public bool? NeedDevice { get; set; }
            [NameInMap("Sync")]
            [Validation(Required=false)]
            public string Sync { get; set; }
            [NameInMap("AlgoConfigItems")]
            [Validation(Required=false)]
            public string AlgoConfigItems { get; set; }
            [NameInMap("InParamList")]
            [Validation(Required=false)]
            public List<GetAIActionConfigResponseBodyDataInParamList> InParamList { get; set; }
            public class GetAIActionConfigResponseBodyDataInParamList : TeaModel {
                public string DataType { get; set; }
                public bool? NeedConfig { get; set; }
                public List<string> ConfigItems { get; set; }
            }
            [NameInMap("OutParamList")]
            [Validation(Required=false)]
            public List<GetAIActionConfigResponseBodyDataOutParamList> OutParamList { get; set; }
            public class GetAIActionConfigResponseBodyDataOutParamList : TeaModel {
                public string DataType { get; set; }
                public bool? NeedConfig { get; set; }
                public List<string> ConfigItems { get; set; }
            }
        };

    }

}
