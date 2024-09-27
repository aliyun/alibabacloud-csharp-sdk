// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterNodePoolsRequest : TeaModel {
        /// <summary>
        /// <para>Node pool name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nodepool-test</para>
        /// </summary>
        [NameInMap("NodepoolName")]
        [Validation(Required=false)]
        public string NodepoolName { get; set; }

    }

}
