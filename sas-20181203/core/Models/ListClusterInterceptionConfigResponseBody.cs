// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClusterInterceptionConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the configurations of the cluster.</para>
        /// </summary>
        [NameInMap("ClusterConfigList")]
        [Validation(Required=false)]
        public List<ListClusterInterceptionConfigResponseBodyClusterConfigList> ClusterConfigList { get; set; }
        public class ListClusterInterceptionConfigResponseBodyClusterConfigList : TeaModel {
            /// <summary>
            /// <para>The status of the container firewall feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>-1</b>: unknown</description></item>
            /// <item><description><b>0</b>: abnormal</description></item>
            /// <item><description><b>1</b>: normal</description></item>
            /// <item><description><b>2</b>: normal to be confirmed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ClusterCNNFStatus")]
            [Validation(Required=false)]
            public int? ClusterCNNFStatus { get; set; }

            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c9051d30d8a044b4d99e1cb5d25ac****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>container-opa-kill-02</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The type of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ManagedKubernetes</b>: managed Kubernetes cluster</description></item>
            /// <item><description><b>NotManagedKubernetes</b>: non-managed Kubernetes cluster</description></item>
            /// <item><description><b>PrivateKubernetes</b>: private cluster</description></item>
            /// <item><description><b>kubernetes</b>: dedicated Kubernetes cluster</description></item>
            /// <item><description><b>ask</b>: dedicated serverless Kubernetes (ASK) cluster</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ManagedKubernetes</para>
            /// </summary>
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The status of the defense rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InterceptionSwitch")]
            [Validation(Required=false)]
            public int? InterceptionSwitch { get; set; }

            /// <summary>
            /// <para>The number of defense rules that are in effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("OpenRuleCount")]
            [Validation(Required=false)]
            public long? OpenRuleCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the container firewall feature is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SupportCNNF")]
            [Validation(Required=false)]
            public bool? SupportCNNF { get; set; }

            /// <summary>
            /// <para>The total number of defense rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TotalRuleCount")]
            [Validation(Required=false)]
            public long? TotalRuleCount { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListClusterInterceptionConfigResponseBodyPageInfo PageInfo { get; set; }
        public class ListClusterInterceptionConfigResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrrentPage")]
            [Validation(Required=false)]
            public int? CurrrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49FDE92F-A0B8-56CC-B7A8-23B17646****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
