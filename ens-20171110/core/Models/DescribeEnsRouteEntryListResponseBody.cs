// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRouteEntryListResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 路由条目信息。
        /// </summary>
        [NameInMap("RouteEntrys")]
        [Validation(Required=false)]
        public List<DescribeEnsRouteEntryListResponseBodyRouteEntrys> RouteEntrys { get; set; }
        public class DescribeEnsRouteEntryListResponseBodyRouteEntrys : TeaModel {
            /// <summary>
            /// 路由条目的描述信息。
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 路由条目的目标网段。
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// 下一跳
            /// </summary>
            [NameInMap("NextHops")]
            [Validation(Required=false)]
            public List<DescribeEnsRouteEntryListResponseBodyRouteEntrysNextHops> NextHops { get; set; }
            public class DescribeEnsRouteEntryListResponseBodyRouteEntrysNextHops : TeaModel {
                /// <summary>
                /// 下一跳实例ID。
                /// </summary>
                [NameInMap("NextHopId")]
                [Validation(Required=false)]
                public string NextHopId { get; set; }

                /// <summary>
                /// 下一跳类型
                /// </summary>
                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

            }

            /// <summary>
            /// 路由条目的ID。
            /// </summary>
            [NameInMap("RouteEntryId")]
            [Validation(Required=false)]
            public string RouteEntryId { get; set; }

            /// <summary>
            /// 路由条目的名称。
            /// </summary>
            [NameInMap("RouteEntryName")]
            [Validation(Required=false)]
            public string RouteEntryName { get; set; }

            /// <summary>
            /// 路由表ID。
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

            /// <summary>
            /// 路由条目的状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 路由条目的类型
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
