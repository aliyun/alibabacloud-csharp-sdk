// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouteTableListResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RouterTableList")]
        [Validation(Required=false)]
        public DescribeRouteTableListResponseBodyRouterTableList RouterTableList { get; set; }
        public class DescribeRouteTableListResponseBodyRouterTableList : TeaModel {
            [NameInMap("RouterTableListType")]
            [Validation(Required=false)]
            public List<DescribeRouteTableListResponseBodyRouterTableListRouterTableListType> RouterTableListType { get; set; }
            public class DescribeRouteTableListResponseBodyRouterTableListRouterTableListType : TeaModel {
                public string AssociateType { get; set; }
                public string CreationTime { get; set; }
                public string Description { get; set; }
                public DescribeRouteTableListResponseBodyRouterTableListRouterTableListTypeGatewayIds GatewayIds { get; set; }
                public class DescribeRouteTableListResponseBodyRouterTableListRouterTableListTypeGatewayIds : TeaModel {
                    [NameInMap("GatewayIds")]
                    [Validation(Required=false)]
                    public List<string> GatewayIds { get; set; }

                }
                public long? OwnerId { get; set; }
                public string ResourceGroupId { get; set; }
                public string RouteTableId { get; set; }
                public string RouteTableName { get; set; }
                public string RouteTableType { get; set; }
                public string RouterId { get; set; }
                public string RouterType { get; set; }
                public string Status { get; set; }
                public DescribeRouteTableListResponseBodyRouterTableListRouterTableListTypeTags Tags { get; set; }
                public class DescribeRouteTableListResponseBodyRouterTableListRouterTableListTypeTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeRouteTableListResponseBodyRouterTableListRouterTableListTypeTagsTag> Tag { get; set; }
                    public class DescribeRouteTableListResponseBodyRouterTableListRouterTableListTypeTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public DescribeRouteTableListResponseBodyRouterTableListRouterTableListTypeVSwitchIds VSwitchIds { get; set; }
                public class DescribeRouteTableListResponseBodyRouterTableListRouterTableListTypeVSwitchIds : TeaModel {
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public List<string> VSwitchId { get; set; }

                }
                public string VpcId { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
