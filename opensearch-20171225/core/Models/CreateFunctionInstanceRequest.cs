// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateFunctionInstanceRequest : TeaModel {
        /// <summary>
        /// The parameters used to create the instance.
        /// </summary>
        [NameInMap("createParameters")]
        [Validation(Required=false)]
        public List<CreateFunctionInstanceRequestCreateParameters> CreateParameters { get; set; }
        public class CreateFunctionInstanceRequestCreateParameters : TeaModel {
            /// <summary>
            /// The parameter name.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The parameter value.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The CRON expression used to schedule periodic training, in the format of Minutes Hours DayofMonth Month DayofWeek. The default value is empty, which specifies that no periodic training is performed. A value of 0 for DayofWeek specifies Sunday.
        /// </summary>
        [NameInMap("cron")]
        [Validation(Required=false)]
        public string Cron { get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The feature type.
        /// 
        /// *   Default value: PAAS. Training is required before you can use the feature.
        /// </summary>
        [NameInMap("functionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        /// <summary>
        /// The instance name. The name must be 1 to 30 characters in length and can contain letters, digits, and underscores (_). The name is case-sensitive and must start with a letter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The model type. The value varies based on the model.
        /// 
        /// *   Click-through rate (CTR) model: tf_checkpoint
        /// *   Popularity model: pop
        /// *   Category model: offline_inference
        /// *   Hotword model: offline_inference
        /// *   Hint model: offline_inference
        /// *   Hotword model for real-time top searches: near_realtime
        /// *   Personalized hint model: near_realtime
        /// *   Drop-down suggestion model: offline_inference
        /// *   Tokenization model: text
        /// *   Term weight model: tf_checkpoint
        /// *   Synonym model: offline_inference
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// The parameters used to use the instance.
        /// </summary>
        [NameInMap("usageParameters")]
        [Validation(Required=false)]
        public List<CreateFunctionInstanceRequestUsageParameters> UsageParameters { get; set; }
        public class CreateFunctionInstanceRequestUsageParameters : TeaModel {
            /// <summary>
            /// The parameter name.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The parameter value.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
