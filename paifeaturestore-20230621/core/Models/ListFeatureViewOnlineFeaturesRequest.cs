// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListFeatureViewOnlineFeaturesRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("JoinIds")]
        [Validation(Required=false)]
        public List<string> JoinIds { get; set; }

    }

}
