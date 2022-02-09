// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeStoragePlanResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeStoragePlanResponseBodyItems> Items { get; set; }
        public class DescribeStoragePlanResponseBodyItems : TeaModel {
            /// <summary>
            /// AliUid
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// 商品代码
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// 结束时间
            /// </summary>
            [NameInMap("EndTimes")]
            [Validation(Required=false)]
            public string EndTimes { get; set; }

            /// <summary>
            /// 容量单位
            /// </summary>
            [NameInMap("InitCapaCityViewUnit")]
            [Validation(Required=false)]
            public string InitCapaCityViewUnit { get; set; }

            /// <summary>
            /// 总量
            /// </summary>
            [NameInMap("InitCapacityViewValue")]
            [Validation(Required=false)]
            public string InitCapacityViewValue { get; set; }

            /// <summary>
            /// 资源实例ID
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// 周期容量单位
            /// </summary>
            [NameInMap("PeriodCapaCityViewUnit")]
            [Validation(Required=false)]
            public string PeriodCapaCityViewUnit { get; set; }

            /// <summary>
            /// 周期容量
            /// </summary>
            [NameInMap("PeriodCapacityViewValue")]
            [Validation(Required=false)]
            public string PeriodCapacityViewValue { get; set; }

            /// <summary>
            /// 周期时长
            /// </summary>
            [NameInMap("PeriodTime")]
            [Validation(Required=false)]
            public string PeriodTime { get; set; }

            /// <summary>
            /// 产品Code
            /// </summary>
            [NameInMap("ProdCode")]
            [Validation(Required=false)]
            public string ProdCode { get; set; }

            /// <summary>
            /// 购买时间
            /// </summary>
            [NameInMap("PurchaseTimes")]
            [Validation(Required=false)]
            public string PurchaseTimes { get; set; }

            /// <summary>
            /// 开始时间
            /// </summary>
            [NameInMap("StartTimes")]
            [Validation(Required=false)]
            public string StartTimes { get; set; }

            /// <summary>
            /// 状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 存储包类型
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// 资源包类型
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
