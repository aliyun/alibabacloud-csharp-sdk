/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20190430.Models
{
    public class CreateComputeTaskRequest : TeaModel {
        [NameInMap("AlgorithmCodeList")]
        [Validation(Required=false)]
        public string AlgorithmCodeList { get; set; }

        [NameInMap("DeviceCodeList")]
        [Validation(Required=false)]
        public string DeviceCodeList { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        [NameInMap("VcsId")]
        [Validation(Required=false)]
        public string VcsId { get; set; }

    }

}
