// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudSupportRegionsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>256959D5-3B45-54CD-A66D-F75F11E8E754</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SupportRegions")]
        [Validation(Required=false)]
        public List<string> SupportRegions { get; set; }

    }

}
