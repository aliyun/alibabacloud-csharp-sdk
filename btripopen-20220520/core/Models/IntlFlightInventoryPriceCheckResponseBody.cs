// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightInventoryPriceCheckResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response object.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightInventoryPriceCheckResponseBodyModule Module { get; set; }
        public class IntlFlightInventoryPriceCheckResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>Indicates whether the verification passed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("check_success")]
            [Validation(Required=false)]
            public bool? CheckSuccess { get; set; }

            /// <summary>
            /// <para>The failure type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: insufficient seats.</description></item>
            /// <item><description>1: price changed.</description></item>
            /// <item><description>2: total price verification failed.</description></item>
            /// <item><description>3: invalid product.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("fail_type")]
            [Validation(Required=false)]
            public int? FailType { get; set; }

            /// <summary>
            /// <para>The price change information. Only has a value when failType = 1 (price changed).</para>
            /// </summary>
            [NameInMap("passenger_changed_price_info_list")]
            [Validation(Required=false)]
            public List<IntlFlightInventoryPriceCheckResponseBodyModulePassengerChangedPriceInfoList> PassengerChangedPriceInfoList { get; set; }
            public class IntlFlightInventoryPriceCheckResponseBodyModulePassengerChangedPriceInfoList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the price changed. Valid values: true (price changed) and false (price not changed).</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("changed")]
                [Validation(Required=false)]
                public bool? Changed { get; set; }

                /// <summary>
                /// <para>The price information after the change.</para>
                /// </summary>
                [NameInMap("changed_price")]
                [Validation(Required=false)]
                public IntlFlightInventoryPriceCheckResponseBodyModulePassengerChangedPriceInfoListChangedPrice ChangedPrice { get; set; }
                public class IntlFlightInventoryPriceCheckResponseBodyModulePassengerChangedPriceInfoListChangedPrice : TeaModel {
                    /// <summary>
                    /// <para>The tax amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12000</para>
                    /// </summary>
                    [NameInMap("tax_price")]
                    [Validation(Required=false)]
                    public long? TaxPrice { get; set; }

                    /// <summary>
                    /// <para>The ticket price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90000</para>
                    /// </summary>
                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public long? TicketPrice { get; set; }

                }

                /// <summary>
                /// <para>The price information before the change.</para>
                /// </summary>
                [NameInMap("original_price")]
                [Validation(Required=false)]
                public IntlFlightInventoryPriceCheckResponseBodyModulePassengerChangedPriceInfoListOriginalPrice OriginalPrice { get; set; }
                public class IntlFlightInventoryPriceCheckResponseBodyModulePassengerChangedPriceInfoListOriginalPrice : TeaModel {
                    /// <summary>
                    /// <para>The tax amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12000</para>
                    /// </summary>
                    [NameInMap("tax_price")]
                    [Validation(Required=false)]
                    public long? TaxPrice { get; set; }

                    /// <summary>
                    /// <para>The ticket price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80000</para>
                    /// </summary>
                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public long? TicketPrice { get; set; }

                }

                /// <summary>
                /// <para>The passenger type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("passenger_type")]
                [Validation(Required=false)]
                public int? PassengerType { get; set; }

            }

            /// <summary>
            /// <para>The key generated after successful verification. Pass this key when creating an order to ensure the order price matches the price from this request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fcoid_deb6372db8194f1c94c23bc4fadc508d</para>
            /// </summary>
            [NameInMap("render_key")]
            [Validation(Required=false)]
            public string RenderKey { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Set by the server. The value is false when an exception occurs or the result is null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2103ad1516839612078738332dea5c</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
