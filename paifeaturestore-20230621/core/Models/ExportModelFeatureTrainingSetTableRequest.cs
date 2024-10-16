// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ExportModelFeatureTrainingSetTableRequest : TeaModel {
        [NameInMap("FeatureViewConfig")]
        [Validation(Required=false)]
        public Dictionary<string, FeatureViewConfigValue> FeatureViewConfig { get; set; }

        [NameInMap("LabelInputConfig")]
        [Validation(Required=false)]
        public ExportModelFeatureTrainingSetTableRequestLabelInputConfig LabelInputConfig { get; set; }
        public class ExportModelFeatureTrainingSetTableRequestLabelInputConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-02 00:00:00</para>
            /// </summary>
            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }

            [NameInMap("Partitions")]
            [Validation(Required=false)]
            public Dictionary<string, Dictionary<string, object>> Partitions { get; set; }

        }

        [NameInMap("RealTimeIterateInterval")]
        [Validation(Required=false)]
        public long? RealTimeIterateInterval { get; set; }

        [NameInMap("RealTimePartitionCountValue")]
        [Validation(Required=false)]
        public long? RealTimePartitionCountValue { get; set; }

        [NameInMap("TrainingSetConfig")]
        [Validation(Required=false)]
        public ExportModelFeatureTrainingSetTableRequestTrainingSetConfig TrainingSetConfig { get; set; }
        public class ExportModelFeatureTrainingSetTableRequestTrainingSetConfig : TeaModel {
            [NameInMap("Partitions")]
            [Validation(Required=false)]
            public Dictionary<string, Dictionary<string, object>> Partitions { get; set; }

        }

    }

}
