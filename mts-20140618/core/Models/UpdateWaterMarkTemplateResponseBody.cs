// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateWaterMarkTemplateResponseBody : TeaModel {
        [NameInMap("WaterMarkTemplate")]
        [Validation(Required=false)]
        public UpdateWaterMarkTemplateResponseBodyWaterMarkTemplate WaterMarkTemplate { get; set; }
        public class UpdateWaterMarkTemplateResponseBodyWaterMarkTemplate : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("RatioRefer")]
            [Validation(Required=false)]
            public UpdateWaterMarkTemplateResponseBodyWaterMarkTemplateRatioRefer RatioRefer { get; set; }
            public class UpdateWaterMarkTemplateResponseBodyWaterMarkTemplateRatioRefer : TeaModel {
                [NameInMap("Dx")]
                [Validation(Required=false)]
                public string Dx { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                [NameInMap("Dy")]
                [Validation(Required=false)]
                public string Dy { get; set; }

            }
            [NameInMap("ReferPos")]
            [Validation(Required=false)]
            public string ReferPos { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("Dx")]
            [Validation(Required=false)]
            public string Dx { get; set; }
            [NameInMap("Width")]
            [Validation(Required=false)]
            public string Width { get; set; }
            [NameInMap("Height")]
            [Validation(Required=false)]
            public string Height { get; set; }
            [NameInMap("Timeline")]
            [Validation(Required=false)]
            public UpdateWaterMarkTemplateResponseBodyWaterMarkTemplateTimeline Timeline { get; set; }
            public class UpdateWaterMarkTemplateResponseBodyWaterMarkTemplateTimeline : TeaModel {
                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

            }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Dy")]
            [Validation(Required=false)]
            public string Dy { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
