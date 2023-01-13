// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListEffectiveOrdersResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The information about orders.
        /// </summary>
        [NameInMap("OrderSummary")]
        [Validation(Required=false)]
        public List<ListEffectiveOrdersResponseBodyOrderSummary> OrderSummary { get; set; }
        public class ListEffectiveOrdersResponseBodyOrderSummary : TeaModel {
            /// <summary>
            /// The commodity code of DMS.
            /// 
            /// *   dms_pre_public_cn: DMS that uses the subscription billing method
            /// *   dms_post_public_cn: DMS that uses the pay-as-you-go billing method
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// The type of the service.
            /// 
            /// *   **VersionType**: DMS that supports control modes
            /// *   **SensitiveDataProtection**: DMS that supports sensitive data protection
            /// </summary>
            [NameInMap("CommodityType")]
            [Validation(Required=false)]
            public string CommodityType { get; set; }

            /// <summary>
            /// Details about the orders.
            /// </summary>
            [NameInMap("OrderList")]
            [Validation(Required=false)]
            public List<ListEffectiveOrdersResponseBodyOrderSummaryOrderList> OrderList { get; set; }
            public class ListEffectiveOrdersResponseBodyOrderSummaryOrderList : TeaModel {
                /// <summary>
                /// The UID of the user who placed the order.
                /// </summary>
                [NameInMap("BuyerId")]
                [Validation(Required=false)]
                public string BuyerId { get; set; }

                /// <summary>
                /// The time when the instance expires.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The maximum number of database instances that you can use DMS to manage.
                /// </summary>
                [NameInMap("InsNum")]
                [Validation(Required=false)]
                public string InsNum { get; set; }

                /// <summary>
                /// The ID of the instance for the purchased service.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The ID of the order.
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// The time when the instance is started.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// The sum of the number of instances that you can use DMS to manage in all orders.
            /// </summary>
            [NameInMap("TotalQuota")]
            [Validation(Required=false)]
            public int? TotalQuota { get; set; }

            /// <summary>
            /// The control mode of DMS. Valid values:
            /// 
            /// *   **stand**: Stable Change
            /// *   **safety**: Security Collaboration
            /// </summary>
            [NameInMap("VersionType")]
            [Validation(Required=false)]
            public string VersionType { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
