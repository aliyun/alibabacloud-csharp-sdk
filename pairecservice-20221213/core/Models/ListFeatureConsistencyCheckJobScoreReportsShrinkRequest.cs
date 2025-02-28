// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListFeatureConsistencyCheckJobScoreReportsShrinkRequest : TeaModel {
        [NameInMap("ExcludeRequestIds")]
        [Validation(Required=false)]
        public string ExcludeRequestIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pairec-cn-********</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
