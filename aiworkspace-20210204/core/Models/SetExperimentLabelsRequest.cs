// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class SetExperimentLabelsRequest : TeaModel {
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<LabelInfo> Labels { get; set; }

    }

}
