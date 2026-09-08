// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class Features : TeaModel {
        /// <summary>
        /// <para>The Quota feature.</para>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public FeaturesQuota Quota { get; set; }
        public class FeaturesQuota : TeaModel {
            /// <summary>
            /// <para>Indicates whether the feature is started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsEnabled")]
            [Validation(Required=false)]
            public bool? IsEnabled { get; set; }

        }

    }

}
