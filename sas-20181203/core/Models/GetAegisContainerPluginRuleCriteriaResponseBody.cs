// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAegisContainerPluginRuleCriteriaResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the search condition.</para>
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<GetAegisContainerPluginRuleCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class GetAegisContainerPluginRuleCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// <para>The name of the search condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>instanceId</b>: the ID of the container instance.</description></item>
            /// <item><description><b>clusterId</b>: the cluster ID.</description></item>
            /// <item><description><b>regionId</b>: the ID of the region in which the container resides.</description></item>
            /// <item><description><b>clusterName</b>: the name of the cluster.</description></item>
            /// <item><description><b>clusterType</b>: the type of the cluster.</description></item>
            /// <item><description><b>hostIp</b>: the public IP address.</description></item>
            /// <item><description><b>pod</b>: the pod.</description></item>
            /// <item><description><b>podIp</b>: the IP address of the pod.</description></item>
            /// <item><description><b>containerId</b>: the container ID.</description></item>
            /// <item><description><b>containerScope</b>: the type of the container.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>containerScope</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the search condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>input</b>: The search condition needs to be specified.</description></item>
            /// <item><description><b>select</b>: The search condition is an option that can be selected from the drop-down list.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>select</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NO,YES</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DA8133CC-CCA0-5CF2-BF64-FE7D52C44***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
