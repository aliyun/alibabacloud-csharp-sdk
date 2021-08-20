// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateDIProjectConfigRequest : TeaModel {
        [NameInMap("ProjectId")]
        [Validation(Required=true)]
        public long? ProjectId { get; set; }

        [NameInMap("DestinationType")]
        [Validation(Required=true)]
        public string DestinationType { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("ProjectConfig")]
        [Validation(Required=true)]
        public string ProjectConfig { get; set; }

    }

}
