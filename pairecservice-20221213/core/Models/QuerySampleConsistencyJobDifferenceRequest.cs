// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class QuerySampleConsistencyJobDifferenceRequest : TeaModel {
        [NameInMap("FeatureName")]
        [Validation(Required=false)]
        public string FeatureName { get; set; }

        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public string FeatureType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
