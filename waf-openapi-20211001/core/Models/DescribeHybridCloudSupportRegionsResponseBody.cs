// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudSupportRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>256959D5-3B45-54CD-A66D-F75F11E8E754</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of regions that are supported for hybrid cloud access.</para>
        /// </summary>
        [NameInMap("SupportRegions")]
        [Validation(Required=false)]
        public List<string> SupportRegions { get; set; }

    }

}
