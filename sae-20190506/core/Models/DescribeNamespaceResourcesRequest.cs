// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeNamespaceResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the namespace. The region ID is not included. We recommend that you use this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("NameSpaceShortId")]
        [Validation(Required=false)]
        public string NameSpaceShortId { get; set; }

        /// <summary>
        /// <para>The ID of the namespace. The format is <c>Region ID:Namespace name</c>. This parameter is retained for backward compatibility. If you specify this parameter, <c>NameSpaceShortId</c> is ignored. We recommend that you use <c>NameSpaceShortId</c> to simplify the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

    }

}
