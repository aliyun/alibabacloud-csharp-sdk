// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class CreateCostUnitResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateCostUnitResponseBodyData Data { get; set; }
        public class CreateCostUnitResponseBodyData : TeaModel {
            [NameInMap("CostUnitDtoList")]
            [Validation(Required=false)]
            public List<CreateCostUnitResponseBodyDataCostUnitDtoList> CostUnitDtoList { get; set; }
            public class CreateCostUnitResponseBodyDataCostUnitDtoList : TeaModel {
                [NameInMap("OwnerUid")]
                [Validation(Required=false)]
                public long? OwnerUid { get; set; }

                [NameInMap("ParentUnitId")]
                [Validation(Required=false)]
                public long? ParentUnitId { get; set; }

                [NameInMap("UnitId")]
                [Validation(Required=false)]
                public long? UnitId { get; set; }

                [NameInMap("UnitName")]
                [Validation(Required=false)]
                public string UnitName { get; set; }

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
