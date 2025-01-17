// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertOutputGroup : TeaModel {
        [NameInMap("GroupConfig")]
        [Validation(Required=false)]
        public MediaConvertOutputGroupConfig GroupConfig { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public List<MediaConvertOutputGroupOutput> Outputs { get; set; }

    }

}
