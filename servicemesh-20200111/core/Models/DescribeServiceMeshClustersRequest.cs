// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeServiceMeshClustersRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>The position where the query starts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        /// <summary>
        /// <para>The ASM instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb8963379255149cb98c8686f274x****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
