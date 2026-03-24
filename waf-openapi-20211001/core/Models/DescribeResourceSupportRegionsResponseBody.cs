// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResourceSupportRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates the request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58FDF266-3D56-5DE8-91E0-96A26BAB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of region IDs supported by transparent proxy mode.</para>
        /// </summary>
        [NameInMap("SupportRegions")]
        [Validation(Required=false)]
        public List<string> SupportRegions { get; set; }

    }

}
