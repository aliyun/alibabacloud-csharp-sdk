// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifySearchParametersRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the PolarDB primary cluster, which is used to locate the Search cluster associated with the current account. Before you call this operation, you must enable the Search feature in the console. You can check the status by using the SearchClusterStatus field returned by DescribeDBClusterAttribute. Usage notes: Prerequisites: The cluster must have the Search feature enabled in the console. You can verify the status by using the SearchClusterStatus field returned by DescribeDBClusterAttribute.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-xxxxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>A non-empty JSON object string where the keys are parameter names and all values must be strings, such as 10% for percentages or 48mb for capacities. You can only modify parameters that are visible and modifiable in the template of the current version. Dynamic parameters take effect and are persisted immediately. Static parameters take effect after a restart triggered by the task flow. A success response only indicates that the task is accepted.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;indices.memory.index_buffer_size&quot;:&quot;10%&quot;,&quot;indices.memory.min_index_buffer_size&quot;:&quot;48mb&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

    }

}
