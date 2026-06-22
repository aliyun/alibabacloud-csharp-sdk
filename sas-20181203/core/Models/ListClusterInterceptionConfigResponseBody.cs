// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClusterInterceptionConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of cluster configuration information.</para>
        /// </summary>
        [NameInMap("ClusterConfigList")]
        [Validation(Required=false)]
        public List<ListClusterInterceptionConfigResponseBodyClusterConfigList> ClusterConfigList { get; set; }
        public class ListClusterInterceptionConfigResponseBodyClusterConfigList : TeaModel {
            /// <summary>
            /// <para>The container firewall status of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>-1</b>: unknown</description></item>
            /// <item><description><b>0</b>: abnormal</description></item>
            /// <item><description><b>1</b>: normal</description></item>
            /// <item><description><b>2</b>: normal pending confirmation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ClusterCNNFStatus")]
            [Validation(Required=false)]
            public int? ClusterCNNFStatus { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c9051d30d8a044b4d99e1cb5d25ac****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>container-opa-kill-02</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The cluster type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ManagedKubernetes</b>: managed Kubernetes</description></item>
            /// <item><description><b>NotManagedKubernetes</b>: non-managed Kubernetes</description></item>
            /// <item><description><b>PrivateKubernetes</b>: private cluster</description></item>
            /// <item><description><b>kubernetes</b>: dedicated Kubernetes</description></item>
            /// <item><description><b>ask</b>: dedicated ASK.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ManagedKubernetes</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The status of the rule interception switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InterceptionSwitch")]
            [Validation(Required=false)]
            public int? InterceptionSwitch { get; set; }

            /// <summary>
            /// <para>The number of active rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("OpenRuleCount")]
            [Validation(Required=false)]
            public long? OpenRuleCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the container firewall is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SupportCNNF")]
            [Validation(Required=false)]
            public bool? SupportCNNF { get; set; }

            /// <summary>
            /// <para>The total number of rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TotalRuleCount")]
            [Validation(Required=false)]
            public long? TotalRuleCount { get; set; }

        }

        /// <summary>
        /// <para>The paging information for a paged query.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListClusterInterceptionConfigResponseBodyPageInfo PageInfo { get; set; }
        public class ListClusterInterceptionConfigResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of cluster interception rules on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrrentPage")]
            [Validation(Required=false)]
            public int? CurrrentPage { get; set; }

            /// <summary>
            /// <para>The number of cluster interception rules per page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of cluster interception rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49FDE92F-A0B8-56CC-B7A8-23B17646****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
