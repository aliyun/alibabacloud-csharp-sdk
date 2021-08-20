// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QueryPublicModelEngineRequest : TeaModel {
        [NameInMap("Text")]
        [Validation(Required=true)]
        public string Text { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=true)]
        public string ProjectId { get; set; }

    }

}
