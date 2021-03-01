// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListClusterMembersResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ClusterMemberPage")]
        [Validation(Required=false)]
        public ListClusterMembersResponseBodyClusterMemberPage ClusterMemberPage { get; set; }
        public class ListClusterMembersResponseBodyClusterMemberPage : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("ClusterMemberList")]
            [Validation(Required=false)]
            public ListClusterMembersResponseBodyClusterMemberPageClusterMemberList ClusterMemberList { get; set; }
            public class ListClusterMembersResponseBodyClusterMemberPageClusterMemberList : TeaModel {
                [NameInMap("ClusterMember")]
                [Validation(Required=false)]
                public List<ListClusterMembersResponseBodyClusterMemberPageClusterMemberListClusterMember> ClusterMember { get; set; }
                public class ListClusterMembersResponseBodyClusterMemberPageClusterMemberListClusterMember : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                    [NameInMap("EcuId")]
                    [Validation(Required=false)]
                    public string EcuId { get; set; }

                    [NameInMap("EcsId")]
                    [Validation(Required=false)]
                    public string EcsId { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("ClusterMemberId")]
                    [Validation(Required=false)]
                    public string ClusterMemberId { get; set; }

                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                }

            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
