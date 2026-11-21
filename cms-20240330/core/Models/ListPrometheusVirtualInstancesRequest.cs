// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListPrometheusVirtualInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of instances to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The optional cloud services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack-csi-fuse</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The next token for the paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4e5f60718293a4b5c6d7e****8f9a0b1c2d3e4f508f9a0b1c2d3e4f508f9a0b1c2d3e4f50</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
