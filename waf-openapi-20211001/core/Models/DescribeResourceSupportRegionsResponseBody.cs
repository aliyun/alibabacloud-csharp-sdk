// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResourceSupportRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58FD****-3D56-5DE8-91E0-96A26BABFFDD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array of region IDs of the CLB and ECS instances that are added to WAF in cloud native mode.</para>
        /// </summary>
        [NameInMap("SupportRegions")]
        [Validation(Required=false)]
        public List<string> SupportRegions { get; set; }

    }

}
