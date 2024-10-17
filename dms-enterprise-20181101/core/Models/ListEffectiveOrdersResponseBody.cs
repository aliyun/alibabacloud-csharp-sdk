// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListEffectiveOrdersResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The information about orders.</para>
        /// </summary>
        [NameInMap("OrderSummary")]
        [Validation(Required=false)]
        public List<ListEffectiveOrdersResponseBodyOrderSummary> OrderSummary { get; set; }
        public class ListEffectiveOrdersResponseBodyOrderSummary : TeaModel {
            /// <summary>
            /// <para>The commodity code of DMS.</para>
            /// <list type="bullet">
            /// <item><description>dms_pre_public_cn: DMS that uses the subscription billing method</description></item>
            /// <item><description>dms_post_public_cn: DMS that uses the pay-as-you-go billing method</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dms_pre_public_cn</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The type of the service.</para>
            /// <list type="bullet">
            /// <item><description><b>VersionType</b>: DMS that supports control modes</description></item>
            /// <item><description><b>SensitiveDataProtection</b>: DMS that supports sensitive data protection</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VersionType</para>
            /// </summary>
            [NameInMap("CommodityType")]
            [Validation(Required=false)]
            public string CommodityType { get; set; }

            /// <summary>
            /// <para>Details about the orders.</para>
            /// </summary>
            [NameInMap("OrderList")]
            [Validation(Required=false)]
            public List<ListEffectiveOrdersResponseBodyOrderSummaryOrderList> OrderList { get; set; }
            public class ListEffectiveOrdersResponseBodyOrderSummaryOrderList : TeaModel {
                /// <summary>
                /// <para>The UID of the user who placed the order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2698420314****</para>
                /// </summary>
                [NameInMap("BuyerId")]
                [Validation(Required=false)]
                public string BuyerId { get; set; }

                /// <summary>
                /// <para>The time when the instance expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-11-24 00:00:00</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The maximum number of database instances that you can use DMS to manage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("InsNum")]
                [Validation(Required=false)]
                public string InsNum { get; set; }

                /// <summary>
                /// <para>The ID of the instance for the purchased service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-bp1xd1v866****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2190037****</para>
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>The time when the instance is started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-24 00:00:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// <para>The sum of the number of instances that you can use DMS to manage in all orders.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalQuota")]
            [Validation(Required=false)]
            public int? TotalQuota { get; set; }

            /// <summary>
            /// <para>The control mode of DMS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>stand</b>: Stable Change</description></item>
            /// <item><description><b>safety</b>: Security Collaboration</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>safety</para>
            /// </summary>
            [NameInMap("VersionType")]
            [Validation(Required=false)]
            public string VersionType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8FE12AA-300D-5FDF-806F-C2CB99161F32</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
