// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class UpdateChannelConfigRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BatchTimeout")]
        [Validation(Required=false)]
        public int? BatchTimeout { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MaxMessageCount")]
        [Validation(Required=false)]
        public int? MaxMessageCount { get; set; }

        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PreferredMaxBytes")]
        [Validation(Required=false)]
        public int? PreferredMaxBytes { get; set; }

    }

}
