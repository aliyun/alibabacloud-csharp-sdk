// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class CreateModelFeatureTrainingSetFGTableResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>project_model_training_set_fg</para>
        /// </summary>
        [NameInMap("TrainingSetFGTableName")]
        [Validation(Required=false)]
        public string TrainingSetFGTableName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>93FF6A91-5326-5FA1-9D89-DB46DAA99E55</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
