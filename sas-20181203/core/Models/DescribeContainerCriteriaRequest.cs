// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerCriteriaRequest : TeaModel {
        /// <summary>
        /// <para>The search field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pod</b>: pod.</description></item>
        /// <item><description><b>appName</b>: application name.</description></item>
        /// <item><description><b>clusterId</b>: cluster ID.</description></item>
        /// <item><description><b>namespace</b>: namespace.</description></item>
        /// <item><description><b>image</b>: image.</description></item>
        /// <item><description><b>containerScan</b>: container scan.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>clusterId</para>
        /// </summary>
        [NameInMap("GroupField")]
        [Validation(Required=false)]
        public string GroupField { get; set; }

        /// <summary>
        /// <para>The value of the search field. Fuzzy match is supported for application names, node names, namespaces, cluster names, public IP addresses, pod addresses, regions, pods, instance IDs, cluster IDs, and container IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cfb41a869c71e4678a97021582dd8a****</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
