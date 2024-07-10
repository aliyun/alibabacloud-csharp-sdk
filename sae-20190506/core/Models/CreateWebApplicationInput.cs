// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateWebApplicationInput : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RevisionConfig")]
        [Validation(Required=false)]
        public RevisionConfig RevisionConfig { get; set; }

        [NameInMap("WebNetworkConfig")]
        [Validation(Required=false)]
        public WebNetworkConfig WebNetworkConfig { get; set; }

        [NameInMap("WebScalingConfig")]
        [Validation(Required=false)]
        public WebScalingConfig WebScalingConfig { get; set; }

        [NameInMap("WebTrafficConfig")]
        [Validation(Required=false)]
        public WebTrafficConfig WebTrafficConfig { get; set; }

    }

}
