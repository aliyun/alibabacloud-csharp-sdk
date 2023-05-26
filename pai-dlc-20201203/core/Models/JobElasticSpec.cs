// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobElasticSpec : TeaModel {
        [NameInMap("AIMasterDockerImage")]
        [Validation(Required=false)]
        public string AIMasterDockerImage { get; set; }

        [NameInMap("AIMasterType")]
        [Validation(Required=false)]
        public string AIMasterType { get; set; }

        [NameInMap("EDPMaxParallelism")]
        [Validation(Required=false)]
        public int? EDPMaxParallelism { get; set; }

        [NameInMap("EDPMinParallelism")]
        [Validation(Required=false)]
        public int? EDPMinParallelism { get; set; }

        [NameInMap("ElasticStrategy")]
        [Validation(Required=false)]
        public string ElasticStrategy { get; set; }

        [NameInMap("EnableAIMaster")]
        [Validation(Required=false)]
        public bool? EnableAIMaster { get; set; }

        [NameInMap("EnableEDP")]
        [Validation(Required=false)]
        public bool? EnableEDP { get; set; }

        [NameInMap("EnableElasticTraining")]
        [Validation(Required=false)]
        public bool? EnableElasticTraining { get; set; }

        [NameInMap("EnablePsJobElasticPS")]
        [Validation(Required=false)]
        public bool? EnablePsJobElasticPS { get; set; }

        [NameInMap("EnablePsJobElasticWorker")]
        [Validation(Required=false)]
        public bool? EnablePsJobElasticWorker { get; set; }

        [NameInMap("EnablePsResourceEstimate")]
        [Validation(Required=false)]
        public bool? EnablePsResourceEstimate { get; set; }

        [NameInMap("MaxParallelism")]
        [Validation(Required=false)]
        public int? MaxParallelism { get; set; }

        [NameInMap("MinParallelism")]
        [Validation(Required=false)]
        public int? MinParallelism { get; set; }

        [NameInMap("PSMaxParallelism")]
        [Validation(Required=false)]
        public int? PSMaxParallelism { get; set; }

        [NameInMap("PSMinParallelism")]
        [Validation(Required=false)]
        public int? PSMinParallelism { get; set; }

    }

}
