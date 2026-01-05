// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListComputeResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>Pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListComputeResourcesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListComputeResourcesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The list of computing resources. Each element is a computing resource group that contains information about the development environment (if any) and the production environment.</para>
            /// </summary>
            [NameInMap("ComputeResources")]
            [Validation(Required=false)]
            public List<ListComputeResourcesResponseBodyPagingInfoComputeResources> ComputeResources { get; set; }
            public class ListComputeResourcesResponseBodyPagingInfoComputeResources : TeaModel {
                /// <summary>
                /// <para>Details of a single computing resource.</para>
                /// </summary>
                [NameInMap("ComputeResource")]
                [Validation(Required=false)]
                public List<ListComputeResourcesResponseBodyPagingInfoComputeResourcesComputeResource> ComputeResource { get; set; }
                public class ListComputeResourcesResponseBodyPagingInfoComputeResourcesComputeResource : TeaModel {
                    /// <summary>
                    /// <para>The category of the added compute resource. Different types have different subtypes with corresponding parameter constraints. Examples: InstanceMode: The instance mode. UrlMode: The connection string mode.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\n    \&quot;clusterIdentifier\&quot;: \&quot;c-da123456\&quot;,\n    \&quot;database\&quot;: \&quot;testdb\&quot;,\n    \&quot;loginMode\&quot;:\&quot;Anonymous\&quot;,\n    \&quot;defaultFS\&quot;:\&quot;127.0.0.1\&quot;,\n    \&quot;envType\&quot;: \&quot;Prod\&quot;\n}</para>
                    /// </summary>
                    [NameInMap("ConnectionProperties")]
                    [Validation(Required=false)]
                    public object ConnectionProperties { get; set; }

                    /// <summary>
                    /// <para>The specific connection configuration details for the computing resource, including the connection address, access identity, and environment information. envType, which specifies the computing resource environment, is a property of this object. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Dev</description></item>
                    /// <item><description>Prod Different types of computing resources have different attribute specifications under different configuration modes (ConnectionPropertiesMode).</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>UrlMode</para>
                    /// </summary>
                    [NameInMap("ConnectionPropertiesMode")]
                    [Validation(Required=false)]
                    public string ConnectionPropertiesMode { get; set; }

                    /// <summary>
                    /// <para>The creation time (timestamp).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1624387842781448</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>The creator ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1648711113000</para>
                    /// </summary>
                    [NameInMap("CreateUser")]
                    [Validation(Required=false)]
                    public string CreateUser { get; set; }

                    /// <summary>
                    /// <para>The unique identifier of the computing resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>home_feed</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The computing resource ID, which is the unique identifier for the resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8649832502405358603</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The last modified time of the computing resource (timestamp).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1624387842781448</para>
                    /// </summary>
                    [NameInMap("ModifyTime")]
                    [Validation(Required=false)]
                    public long? ModifyTime { get; set; }

                    /// <summary>
                    /// <para>The modifier ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1648711113000</para>
                    /// </summary>
                    [NameInMap("ModifyUser")]
                    [Validation(Required=false)]
                    public string ModifyUser { get; set; }

                    /// <summary>
                    /// <para>Specifies whether it is the default compute resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("WhetherDefault")]
                    [Validation(Required=false)]
                    public bool? WhetherDefault { get; set; }

                }

                /// <summary>
                /// <para>The name of the computing resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cal_all_vemg_workflow_parallel</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the computing resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hologres</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of records per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C352CB7-CD88-50CF-9D0D-E81BDF02XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
