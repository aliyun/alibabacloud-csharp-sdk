// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSophonCommandsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSophonCommandsResponseBodyData> Data { get; set; }
        public class DescribeSophonCommandsResponseBodyData : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ParamConfig")]
            [Validation(Required=false)]
            public List<DescribeSophonCommandsResponseBodyDataParamConfig> ParamConfig { get; set; }
            public class DescribeSophonCommandsResponseBodyDataParamConfig : TeaModel {
                [NameInMap("CheckField")]
                [Validation(Required=false)]
                public string CheckField { get; set; }

                [NameInMap("Field")]
                [Validation(Required=false)]
                public string Field { get; set; }

                [NameInMap("Necessary")]
                [Validation(Required=false)]
                public bool? Necessary { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
