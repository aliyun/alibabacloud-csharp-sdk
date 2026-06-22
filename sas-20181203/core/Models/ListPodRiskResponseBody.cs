// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListPodRiskResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListPodRiskResponseBodyPageInfo PageInfo { get; set; }
        public class ListPodRiskResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page when paging is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page when paging is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page when paging is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2-</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>29</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The security risks of pod groups.</para>
        /// </summary>
        [NameInMap("PodRiskList")]
        [Validation(Required=false)]
        public List<ListPodRiskResponseBodyPodRiskList> PodRiskList { get; set; }
        public class ListPodRiskResponseBodyPodRiskList : TeaModel {
            /// <summary>
            /// <para>The number of alerts in the pod group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AlarmCount")]
            [Validation(Required=false)]
            public int? AlarmCount { get; set; }

            /// <summary>
            /// <para>The ID of the container cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c1d903a628af043659a043af59d89****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test66</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The timestamp when the pod group was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1644283112720</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The number of baseline issues in the pod group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HcCount")]
            [Validation(Required=false)]
            public int? HcCount { get; set; }

            /// <summary>
            /// <para>The instance ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-7yvdq597****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The Kubernetes namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kube-system</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The node name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The pod group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>expoit-xxx-b****</para>
            /// </summary>
            [NameInMap("Pod")]
            [Validation(Required=false)]
            public string Pod { get; set; }

            /// <summary>
            /// <para>The IP address of the pod group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.0.XXX.XXX</para>
            /// </summary>
            [NameInMap("PodIp")]
            [Validation(Required=false)]
            public string PodIp { get; set; }

            /// <summary>
            /// <para>The number of vulnerabilities in the pod group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VulCount")]
            [Validation(Required=false)]
            public int? VulCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94254AD7-5026-5847-833B-403C2326BD6E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
