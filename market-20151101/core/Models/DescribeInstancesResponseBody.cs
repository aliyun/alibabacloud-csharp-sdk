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
                [NameInMap("ApiJson")]
                [Validation(Required=false)]
                public string ApiJson { get; set; }

                [NameInMap("AppJson")]
                [Validation(Required=false)]
                public string AppJson { get; set; }

                [NameInMap("BeganOn")]
                [Validation(Required=false)]
                public long? BeganOn { get; set; }

                [NameInMap("CreatedOn")]
                [Validation(Required=false)]
                public long? CreatedOn { get; set; }

                [NameInMap("EndOn")]
                [Validation(Required=false)]
                public long? EndOn { get; set; }

                [NameInMap("ExtendJson")]
                [Validation(Required=false)]
                public string ExtendJson { get; set; }

                [NameInMap("HostJson")]
                [Validation(Required=false)]
                public string HostJson { get; set; }

                [NameInMap("IdaasJson")]
                [Validation(Required=false)]
                public string IdaasJson { get; set; }

                [NameInMap("ImageJson")]
                [Validation(Required=false)]
                public string ImageJson { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                [NameInMap("ProductSkuCode")]
                [Validation(Required=false)]
                public string ProductSkuCode { get; set; }

                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SupplierName")]
                [Validation(Required=false)]
                public string SupplierName { get; set; }

            }

        }

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
