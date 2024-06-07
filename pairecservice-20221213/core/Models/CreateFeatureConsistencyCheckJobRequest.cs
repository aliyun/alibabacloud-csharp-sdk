// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateFeatureConsistencyCheckJobRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("FeatureConsistencyCheckJobConfigId")]
        [Validation(Required=false)]
        public string FeatureConsistencyCheckJobConfigId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SamplingDuration")]
        [Validation(Required=false)]
        public int? SamplingDuration { get; set; }

    }

}
