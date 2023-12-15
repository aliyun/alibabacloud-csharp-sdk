// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class UpdateProjectRequest : TeaModel {
        [NameInMap("AggregateSceneCode")]
        [Validation(Required=false)]
        public string AggregateSceneCode { get; set; }

        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
