// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateFunctionInstanceRequest : TeaModel {
        /// <summary>
        /// The parameters that are used to create the instance.
        /// </summary>
        [NameInMap("createParameters")]
        [Validation(Required=false)]
        public List<CreateFunctionInstanceRequestCreateParameters> CreateParameters { get; set; }
        public class CreateFunctionInstanceRequestCreateParameters : TeaModel {
            /// <summary>
            /// The name of the parameter.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The value of the parameter.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The cron expression used to schedule periodic training, in the format of (Minutes Hours DayofMonth Month DayofWeek). The default value is empty, which indicates that no periodic training is performed. DayofWeek 0 indicates Sunday.
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
        /// The type of the feature. Valid values:
        /// 
        /// *   PAAS: This is the default value. Training is required before you can use the feature.
        /// </summary>
        [NameInMap("functionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        /// <summary>
        /// The name of the instance. The name must be 1 to 30 characters in length and can contain letters, digits, and underscores (\_). The name is case-sensitive and must start with a letter.
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The type of the model. The following features correspond to different model types:
        /// 
        /// *   click-through rate (CTR) model: tf_checkpoint
        /// *   Popularity model: pop
        /// *   Category model: offline_inference
        /// *   Hotword model: offline_inference
        /// *   Shading model: offline_inference
        /// *   Drop-down suggestion model: offline_inference
        /// *   Word segmentation model: text
        /// *   Term weight model: tf_checkpoint
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// The parameters that are used to use the instance.
        /// </summary>
        [NameInMap("usageParameters")]
        [Validation(Required=false)]
        public List<CreateFunctionInstanceRequestUsageParameters> UsageParameters { get; set; }
        public class CreateFunctionInstanceRequestUsageParameters : TeaModel {
            /// <summary>
            /// The name of the parameter.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The value of the parameter.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
