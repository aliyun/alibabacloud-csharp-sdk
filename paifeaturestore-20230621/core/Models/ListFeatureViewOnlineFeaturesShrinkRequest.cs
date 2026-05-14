// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListFeatureViewOnlineFeaturesShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;dlrm_hstu&quot;: true}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("JoinIds")]
        [Validation(Required=false)]
        public string JoinIdsShrink { get; set; }

    }

}
