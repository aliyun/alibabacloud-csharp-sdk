// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class QueryInfoFromMdpRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
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

        [NameInMap("MobileSm3")]
        [Validation(Required=false)]
        public string MobileSm3 { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RiskScene")]
        [Validation(Required=false)]
        public string RiskScene { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
