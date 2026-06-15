// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ExportModelFeatureTrainingSetTableRequest : TeaModel {
        /// <summary>
        /// <para>A map of feature view configurations.</para>
        /// </summary>
        [NameInMap("FeatureViewConfig")]
        [Validation(Required=false)]
        public Dictionary<string, FeatureViewConfigValue> FeatureViewConfig { get; set; }

        /// <summary>
        /// <para>The input configuration for the label table.</para>
        /// </summary>
        [NameInMap("LabelInputConfig")]
        [Validation(Required=false)]
        public ExportModelFeatureTrainingSetTableRequestLabelInputConfig LabelInputConfig { get; set; }
        public class ExportModelFeatureTrainingSetTableRequestLabelInputConfig : TeaModel {
            /// <summary>
            /// <para>The event time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-02 00:00:00</para>
            /// </summary>
            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }

            /// <summary>
            /// <para>The list of partitions.</para>
            /// </summary>
            [NameInMap("Partitions")]
            [Validation(Required=false)]
            public Dictionary<string, Dictionary<string, object>> Partitions { get; set; }

        }

        /// <summary>
        /// <para>The polling interval for retrieving real-time features.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RealTimeIterateInterval")]
        [Validation(Required=false)]
        public long? RealTimeIterateInterval { get; set; }

        /// <summary>
        /// <para>The number of days for partition statistics of the real-time feature view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RealTimePartitionCountValue")]
        [Validation(Required=false)]
        public long? RealTimePartitionCountValue { get; set; }

        /// <summary>
        /// <para>The configuration for the training set.</para>
        /// </summary>
        [NameInMap("TrainingSetConfig")]
        [Validation(Required=false)]
        public ExportModelFeatureTrainingSetTableRequestTrainingSetConfig TrainingSetConfig { get; set; }
        public class ExportModelFeatureTrainingSetTableRequestTrainingSetConfig : TeaModel {
            /// <summary>
            /// <para>The list of partitions.</para>
            /// </summary>
            [NameInMap("Partitions")]
            [Validation(Required=false)]
            public Dictionary<string, Dictionary<string, object>> Partitions { get; set; }

        }

    }

}
