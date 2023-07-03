// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20191111.Models
{
    public class FindUserReport4AlinlpRequest : TeaModel {
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public string BeginTime { get; set; }

        [NameInMap("CustomerUserParentId")]
        [Validation(Required=false)]
        public long? CustomerUserParentId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
