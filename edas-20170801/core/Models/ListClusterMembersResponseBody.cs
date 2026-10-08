// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListClusterMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the ECS instances in the cluster.</para>
        /// </summary>
        [NameInMap("ClusterMemberPage")]
        [Validation(Required=false)]
        public ListClusterMembersResponseBodyClusterMemberPage ClusterMemberPage { get; set; }
        public class ListClusterMembersResponseBodyClusterMemberPage : TeaModel {
            [NameInMap("ClusterMemberList")]
            [Validation(Required=false)]
            public ListClusterMembersResponseBodyClusterMemberPageClusterMemberList ClusterMemberList { get; set; }
            public class ListClusterMembersResponseBodyClusterMemberPageClusterMemberList : TeaModel {
                [NameInMap("ClusterMember")]
                [Validation(Required=false)]
                public List<ListClusterMembersResponseBodyClusterMemberPageClusterMemberListClusterMember> ClusterMember { get; set; }
                public class ListClusterMembersResponseBodyClusterMemberPageClusterMemberListClusterMember : TeaModel {
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    [NameInMap("ClusterMemberId")]
                    [Validation(Required=false)]
                    public string ClusterMemberId { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("EcsId")]
                    [Validation(Required=false)]
                    public string EcsId { get; set; }

                    [NameInMap("EcuId")]
                    [Validation(Required=false)]
                    public string EcuId { get; set; }

                    [NameInMap("PrivateIp")]
                    [Validation(Required=false)]
                    public string PrivateIp { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                }

            }

            /// <summary>
            /// <para>The page number of the returned page. If this parameter is not returned, the first page is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of ECS instances returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of pages returned when all ECS instances are returned based on the specified PageSize parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b197-40ab-9155-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
