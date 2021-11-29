// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class CreateClusterBootstrapActionRequest : TeaModel {
        [NameInMap("BootstrapAction")]
        [Validation(Required=false)]
        public List<CreateClusterBootstrapActionRequestBootstrapAction> BootstrapAction { get; set; }
        public class CreateClusterBootstrapActionRequestBootstrapAction : TeaModel {
            [NameInMap("Arg")]
            [Validation(Required=false)]
            public string Arg { get; set; }

            [NameInMap("ExecutionFailStrategy")]
            [Validation(Required=false)]
            public string ExecutionFailStrategy { get; set; }

            [NameInMap("ExecutionMoment")]
            [Validation(Required=false)]
            public string ExecutionMoment { get; set; }

            [NameInMap("ExecutionTarget")]
            [Validation(Required=false)]
            public string ExecutionTarget { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
