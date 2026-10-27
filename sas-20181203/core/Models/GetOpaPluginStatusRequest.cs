// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOpaPluginStatusRequest : TeaModel {
        /// <summary>
        /// <para>The list of cluster IDs.</para>
        /// <remarks>
        /// <para>You can query this value by calling the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public List<string> ClusterIds { get; set; }

    }

}
