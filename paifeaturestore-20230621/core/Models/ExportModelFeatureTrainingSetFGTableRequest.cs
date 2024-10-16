// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ExportModelFeatureTrainingSetFGTableRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TrainingSetFgConfig")]
        [Validation(Required=false)]
        public ExportModelFeatureTrainingSetFGTableRequestTrainingSetFgConfig TrainingSetFgConfig { get; set; }
        public class ExportModelFeatureTrainingSetFGTableRequestTrainingSetFgConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>rank_v1_fg.json</para>
            /// </summary>
            [NameInMap("FgJsonName")]
            [Validation(Required=false)]
            public string FgJsonName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fg_on_odps-1.3.60-jar-with-dependencies.jar</para>
            /// </summary>
            [NameInMap("JarName")]
            [Validation(Required=false)]
            public string JarName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Partitions")]
            [Validation(Required=false)]
            public Dictionary<string, Dictionary<string, object>> Partitions { get; set; }

        }

    }

}
