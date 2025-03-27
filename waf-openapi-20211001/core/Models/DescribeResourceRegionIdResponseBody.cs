// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeResourceRegionIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5905D3F-F674-5177-9E48-466DD3B8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The region IDs of the resources that are added to Web Application Firewall (WAF) by using the SDK integration mode.</para>
        /// </summary>
        [NameInMap("ResourceRegionIds")]
        [Validation(Required=false)]
        public List<string> ResourceRegionIds { get; set; }

    }

}
