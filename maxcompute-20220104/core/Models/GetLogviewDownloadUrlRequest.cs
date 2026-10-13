// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetLogviewDownloadUrlRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to use the OSS VPC endpoint to generate the download link. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: Uses the default OSS endpoint.</description></item>
        /// <item><description>true: Uses the OSS VPC endpoint configured on the server. The download client must have network access to this endpoint.
        /// Default value: false. If this parameter is set to true and no OSS VPC endpoint is configured on the server, link generation fails and does not automatically fall back.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("useVpcEndpoint")]
        [Validation(Required=false)]
        public bool? UseVpcEndpoint { get; set; }

    }

}
