// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class QueryInfoFromMdpRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("MobileMd5")]
        [Validation(Required=false)]
        public string MobileMd5 { get; set; }

        [NameInMap("MobileSha256")]
        [Validation(Required=false)]
        public string MobileSha256 { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RiskScene")]
        [Validation(Required=false)]
        public string RiskScene { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
