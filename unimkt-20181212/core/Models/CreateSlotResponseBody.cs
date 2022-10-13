// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class CreateSlotResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public CreateSlotResponseBodyModel Model { get; set; }
        public class CreateSlotResponseBodyModel : TeaModel {
            [NameInMap("AdSlotCorporateStatus")]
            [Validation(Required=false)]
            public string AdSlotCorporateStatus { get; set; }

            [NameInMap("AdSlotId")]
            [Validation(Required=false)]
            public string AdSlotId { get; set; }

            [NameInMap("AdSlotName")]
            [Validation(Required=false)]
            public string AdSlotName { get; set; }

            [NameInMap("AdSlotStatus")]
            [Validation(Required=false)]
            public string AdSlotStatus { get; set; }

            [NameInMap("AdSlotTemplateId")]
            [Validation(Required=false)]
            public string AdSlotTemplateId { get; set; }

            [NameInMap("AdSlotType")]
            [Validation(Required=false)]
            public string AdSlotType { get; set; }

            [NameInMap("BlockingRule")]
            [Validation(Required=false)]
            public string BlockingRule { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            [NameInMap("InspireScene")]
            [Validation(Required=false)]
            public string InspireScene { get; set; }

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("MediaName")]
            [Validation(Required=false)]
            public string MediaName { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
