// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListModelFeatureAvailableFeaturesRequest : TeaModel {
        /// <summary>
        /// <para>Filter by feature name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f1</para>
        /// </summary>
        [NameInMap("FeatureName")]
        [Validation(Required=false)]
        public string FeatureName { get; set; }

    }

}
