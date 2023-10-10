// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListClusterMembersResponseBody : TeaModel {
        /// <summary>
        /// The information about the ECS instances in the cluster.
        /// </summary>
        [NameInMap("ClusterMemberPage")]
        [Validation(Required=false)]
        public ListClusterMembersResponseBodyClusterMemberPage ClusterMemberPage { get; set; }
        public class ListClusterMembersResponseBodyClusterMemberPage : TeaModel {
            /// <summary>
            /// The list of ECS instances in the cluster.
            /// </summary>
            [NameInMap("ClusterMemberList")]
            [Validation(Required=false)]
            public ListClusterMembersResponseBodyClusterMemberPageClusterMemberList ClusterMemberList { get; set; }
            public class ListClusterMembersResponseBodyClusterMemberPageClusterMemberList : TeaModel {
                [NameInMap("ClusterMember")]
                [Validation(Required=false)]
                public List<ListClusterMembersResponseBodyClusterMemberPageClusterMemberListClusterMember> ClusterMember { get; set; }
                public class ListClusterMembersResponseBodyClusterMemberPageClusterMemberListClusterMember : TeaModel {
                    /// <summary>
                    /// The ID of the cluster.
                    /// </summary>
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    /// <summary>
                    /// The ID of the ECS instance in the cluster.
                    /// </summary>
                    [NameInMap("ClusterMemberId")]
                    [Validation(Required=false)]
                    public string ClusterMemberId { get; set; }

                    /// <summary>
                    /// The timestamp when the ECS instance was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// The ID of the ECS instance.
                    /// </summary>
                    [NameInMap("EcsId")]
                    [Validation(Required=false)]
                    public string EcsId { get; set; }

                    /// <summary>
                    /// The unique ID of the elastic compute unit (ECU). You can run the `dmidecode` command on the ECS instance to query the ECU ID.
                    /// </summary>
                    [NameInMap("EcuId")]
                    [Validation(Required=false)]
                    public string EcuId { get; set; }

                    /// <summary>
                    /// The private IP address for the ECS instance.
                    /// </summary>
                    [NameInMap("PrivateIp")]
                    [Validation(Required=false)]
                    public string PrivateIp { get; set; }

                    /// <summary>
                    /// The state of the ECS instance. Valid values:
                    /// 
                    /// *   1: The instance is running.
                    /// *   0: The instance is being converted.
                    /// *   \-1: The instance fails to be converted.
                    /// *   \-2: The instance is offline.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// The timestamp when the ECS instance was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                }

            }

            /// <summary>
            /// The page number of the returned page. If this parameter is not returned, the first page is returned.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of ECS instances returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of pages returned when all ECS instances are returned based on the specified PageSize parameter.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The message that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
