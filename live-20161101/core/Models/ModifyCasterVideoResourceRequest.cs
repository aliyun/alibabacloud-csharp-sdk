// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyCasterVideoResourceRequest : TeaModel {
        [NameInMap("CasterId")]
        [Validation(Required=true)]
        public string CasterId { get; set; }

        [NameInMap("ResourceId")]
        [Validation(Required=true)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        [NameInMap("LiveStreamUrl")]
        [Validation(Required=false)]
        public string LiveStreamUrl { get; set; }

        [NameInMap("MaterialId")]
        [Validation(Required=false)]
        public string MaterialId { get; set; }

        [NameInMap("VodUrl")]
        [Validation(Required=false)]
        public string VodUrl { get; set; }

        [NameInMap("BeginOffset")]
        [Validation(Required=false)]
        public int? BeginOffset { get; set; }

        [NameInMap("EndOffset")]
        [Validation(Required=false)]
        public int? EndOffset { get; set; }

        [NameInMap("RepeatNum")]
        [Validation(Required=false)]
        public int? RepeatNum { get; set; }

        [NameInMap("PtsCallbackInterval")]
        [Validation(Required=false)]
        public int? PtsCallbackInterval { get; set; }

    }

}
