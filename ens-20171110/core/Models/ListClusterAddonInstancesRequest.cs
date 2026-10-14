// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListClusterAddonInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID. The target cluster must be in the running state. You can verify the state by checking the State field in the response of DescribeClustersV1 or DescribeClusterDetail.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eck-xxxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
