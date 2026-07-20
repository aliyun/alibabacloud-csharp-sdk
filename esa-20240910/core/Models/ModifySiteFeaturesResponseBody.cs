// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ModifySiteFeaturesResponseBody : TeaModel {
        /// <summary>
        /// <para>The site feature information that failed to be cleared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>loadbalance</para>
        /// </summary>
        [NameInMap("FailedFeatures")]
        [Validation(Required=false)]
        public string FailedFeatures { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
