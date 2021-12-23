// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitSubtitleProduceJobRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EditingConfig")]
        [Validation(Required=false)]
        public string EditingConfig { get; set; }

        [NameInMap("InputConfig")]
        [Validation(Required=false)]
        public string InputConfig { get; set; }

        [NameInMap("IsAsync")]
        [Validation(Required=false)]
        public long? IsAsync { get; set; }

        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
