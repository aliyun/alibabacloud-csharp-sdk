// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class RevisionConfig : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Containers")]
        [Validation(Required=false)]
        public List<Container> Containers { get; set; }

        [NameInMap("EnableArmsMetrics")]
        [Validation(Required=false)]
        public bool? EnableArmsMetrics { get; set; }

        [NameInMap("WebNetworkConfig")]
        [Validation(Required=false)]
        public WebNetworkConfig WebNetworkConfig { get; set; }

    }

}
