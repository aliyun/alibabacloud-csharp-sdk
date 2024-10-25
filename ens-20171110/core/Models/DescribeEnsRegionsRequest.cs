// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the node.</para>
        /// <para>By default, all available node IDs are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-dalian-unicom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

    }

}
