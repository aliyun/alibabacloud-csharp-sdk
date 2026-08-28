// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListSourcesResponseBodyData Data { get; set; }
        public class ListSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of sources.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListSourcesResponseBodyDataItems> Items { get; set; }
            public class ListSourcesResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Association completed</para>
                /// </summary>
                [NameInMap("associationReason")]
                [Validation(Required=false)]
                public string AssociationReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ASSOCIATED</para>
                /// </summary>
                [NameInMap("associationStatus")]
                [Validation(Required=false)]
                public string AssociationStatus { get; set; }

                /// <summary>
                /// <para>The creation timestamp. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1719386834548</para>
                /// </summary>
                [NameInMap("createTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The source information when the source type is K8S.</para>
                /// </summary>
                [NameInMap("k8sSourceInfo")]
                [Validation(Required=false)]
                public ListSourcesResponseBodyDataItemsK8sSourceInfo K8sSourceInfo { get; set; }
                public class ListSourcesResponseBodyDataItemsK8sSourceInfo : TeaModel {
                    /// <summary>
                    /// <para>The cluster ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>c09212180612a42adbed6a940d01d***</para>
                    /// </summary>
                    [NameInMap("clusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                }

                /// <summary>
                /// <para>The source information when the source type is MSE_NACOS.</para>
                /// </summary>
                [NameInMap("nacosSourceInfo")]
                [Validation(Required=false)]
                public ListSourcesResponseBodyDataItemsNacosSourceInfo NacosSourceInfo { get; set; }
                public class ListSourcesResponseBodyDataItemsNacosSourceInfo : TeaModel {
                    /// <summary>
                    /// <para>The endpoint of the Nacos instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mse-3353***-nacos-ans.mse.aliyuncs.com:8848</para>
                    /// </summary>
                    [NameInMap("address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    /// <summary>
                    /// <para>The registry ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mse-3353***</para>
                    /// </summary>
                    [NameInMap("clusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    /// <summary>
                    /// <para>The Nacos instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mse_prepaid_public_cn-wuf***</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                }

                /// <summary>
                /// <para>The source name. If the source type is K8S, the name is the container cluster name. If the source type is MSE_NACOS, the name is the Nacos instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>itemcenter-dev-cluster</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rg-xxxx</para>
                /// </summary>
                [NameInMap("resourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>src-crdddallhtgtria***</para>
                /// </summary>
                [NameInMap("sourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <para>The update timestamp. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1719386834548</para>
                /// </summary>
                [NameInMap("updateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The response message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FA9BB94-915B-5299-A694-49FCC7F5DD00</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
