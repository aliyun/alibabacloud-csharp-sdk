// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateNodeRunModeRequest : TeaModel {
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        [NameInMap("SchedulerType")]
        [Validation(Required=false)]
        public int? SchedulerType { get; set; }

    }

}
