// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        [NameInMap("InstanceItems")]
        [Validation(Required=false)]
        public DescribeInstancesResponseBodyInstanceItems InstanceItems { get; set; }
        public class DescribeInstancesResponseBodyInstanceItems : TeaModel {
            [NameInMap("InstanceItem")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstanceItemsInstanceItem> InstanceItem { get; set; }
            public class DescribeInstancesResponseBodyInstanceItemsInstanceItem : TeaModel {
                public string ApiJson { get; set; }
                public string AppJson { get; set; }
                public long? BeganOn { get; set; }
                public long? CreatedOn { get; set; }
                public long? EndOn { get; set; }
                public string ExtendJson { get; set; }
                public string HostJson { get; set; }
                public string IdaasJson { get; set; }
                public string ImageJson { get; set; }
                public long? InstanceId { get; set; }
                public long? OrderId { get; set; }
                public string ProductCode { get; set; }
                public string ProductName { get; set; }
                public string ProductSkuCode { get; set; }
                public string ProductType { get; set; }
                public string Status { get; set; }
                public string SupplierName { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
