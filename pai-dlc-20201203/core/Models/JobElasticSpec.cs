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

        [NameInMap("EnableAIMaster")]
        [Validation(Required=false)]
        public bool? EnableAIMaster { get; set; }

        [NameInMap("EnableElasticTraining")]
        [Validation(Required=false)]
        public bool? EnableElasticTraining { get; set; }

        [NameInMap("EnablePsJobElasticWorker")]
        [Validation(Required=false)]
        public bool? EnablePsJobElasticWorker { get; set; }

        [NameInMap("MaxParallelism")]
        [Validation(Required=false)]
        public int? MaxParallelism { get; set; }

        [NameInMap("MinParallelism")]
        [Validation(Required=false)]
        public int? MinParallelism { get; set; }

    }

}
