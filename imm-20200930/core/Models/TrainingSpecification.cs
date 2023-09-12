// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class TrainingSpecification : TeaModel {
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("ModelSpecification")]
        [Validation(Required=false)]
        public ModelSpecification ModelSpecification { get; set; }

        [NameInMap("Runtime")]
        [Validation(Required=false)]
        public Runtime Runtime { get; set; }

        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        [NameInMap("Transforms")]
        [Validation(Required=false)]
        public List<CustomParams> Transforms { get; set; }

        [NameInMap("ValidationSourceURI")]
        [Validation(Required=false)]
        public string ValidationSourceURI { get; set; }

        [NameInMap("ValidationSplit")]
        [Validation(Required=false)]
        public float? ValidationSplit { get; set; }

    }

}
