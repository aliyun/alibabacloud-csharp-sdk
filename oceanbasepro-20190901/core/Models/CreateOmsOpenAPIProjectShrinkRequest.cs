// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateOmsOpenAPIProjectShrinkRequest : TeaModel {
        [NameInMap("BusinessName")]
        [Validation(Required=false)]
        public string BusinessName { get; set; }

        [NameInMap("DestConfig")]
        [Validation(Required=false)]
        public string DestConfigShrink { get; set; }

        [NameInMap("LabelIds")]
        [Validation(Required=false)]
        public string LabelIdsShrink { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("SourceConfig")]
        [Validation(Required=false)]
        public string SourceConfigShrink { get; set; }

        [NameInMap("TransferMapping")]
        [Validation(Required=false)]
        public string TransferMappingShrink { get; set; }

        [NameInMap("TransferStepConfig")]
        [Validation(Required=false)]
        public string TransferStepConfigShrink { get; set; }

        [NameInMap("WorkerGradeId")]
        [Validation(Required=false)]
        public string WorkerGradeId { get; set; }

    }

}
