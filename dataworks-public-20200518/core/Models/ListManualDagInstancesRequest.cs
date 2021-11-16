// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListManualDagInstancesRequest : TeaModel {
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public string DagId { get; set; }

        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
