// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListFeatureViewOnlineFeaturesResponseBody : TeaModel {
        [NameInMap("OnlineFeatures")]
        [Validation(Required=false)]
        public List<string> OnlineFeatures { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BF349686-C932-55B5-9B31-DAFA395C0E06</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
