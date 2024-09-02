// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetFunctionCurrentVersionRequest : TeaModel {
        /// <summary>
        /// The category. By default, this parameter is left empty.
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The industry. By default, this parameter is left empty, which indicates General-purpose Edition.
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The type of the feature. Valid values:
        /// 
        /// *   PAAS. This is the default value.
        /// *   SAAS.
        /// </summary>
        [NameInMap("functionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        /// <summary>
        /// The type of the model. The following features correspond to different model types:
        /// 
        /// *   CTR model: tf_checkpoint
        /// *   Popularity model: pop
        /// *   Category model: offline_inference
        /// *   Hotword model: offline_inference
        /// *   Shading model: offline_inference
        /// *   Drop-down suggestion model: offline_inference
        /// *   Word segmentation model: text
        /// *   Word weight model: tf_checkpoint
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

    }

}
