// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class UpdateActionRequest : TeaModel {
        [NameInMap("ActionName")]
        [Validation(Required=false)]
        public string ActionName { get; set; }

        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Popularity")]
        [Validation(Required=false)]
        public int? Popularity { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
