// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Hyperparameters : TeaModel {
        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public long? BackupInterval { get; set; }

        [NameInMap("BatchSize")]
        [Validation(Required=false)]
        public long? BatchSize { get; set; }

        [NameInMap("DataLoaderWorkers")]
        [Validation(Required=false)]
        public long? DataLoaderWorkers { get; set; }

        [NameInMap("Evaluator")]
        [Validation(Required=false)]
        public CustomParams Evaluator { get; set; }

        [NameInMap("InputSize")]
        [Validation(Required=false)]
        public List<long?> InputSize { get; set; }

        [NameInMap("MaxEpoch")]
        [Validation(Required=false)]
        public long? MaxEpoch { get; set; }

        [NameInMap("Optimization")]
        [Validation(Required=false)]
        public Optimization Optimization { get; set; }

        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public Schedule Schedule { get; set; }

    }

}
