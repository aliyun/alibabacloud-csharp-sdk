// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ExportModelFeatureTrainingSetFGTableRequest : TeaModel {
        [NameInMap("TrainingSetFgConfig")]
        [Validation(Required=false)]
        public ExportModelFeatureTrainingSetFGTableRequestTrainingSetFgConfig TrainingSetFgConfig { get; set; }
        public class ExportModelFeatureTrainingSetFGTableRequestTrainingSetFgConfig : TeaModel {
            [NameInMap("FgJsonName")]
            [Validation(Required=false)]
            public string FgJsonName { get; set; }

            [NameInMap("JarName")]
            [Validation(Required=false)]
            public string JarName { get; set; }

            [NameInMap("Partitions")]
            [Validation(Required=false)]
            public Dictionary<string, Dictionary<string, object>> Partitions { get; set; }

        }

    }

}
