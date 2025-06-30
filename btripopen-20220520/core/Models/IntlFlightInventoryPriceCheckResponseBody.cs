// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightInventoryPriceCheckResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightInventoryPriceCheckResponseBodyModule Module { get; set; }
        public class IntlFlightInventoryPriceCheckResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("check_success")]
            [Validation(Required=false)]
            public bool? CheckSuccess { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("fail_type")]
            [Validation(Required=false)]
            public int? FailType { get; set; }

            [NameInMap("passenger_changed_price_info_list")]
            [Validation(Required=false)]
            public List<IntlFlightInventoryPriceCheckResponseBodyModulePassengerChangedPriceInfoList> PassengerChangedPriceInfoList { get; set; }
            public class IntlFlightInventoryPriceCheckResponseBodyModulePassengerChangedPriceInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("changed")]
                [Validation(Required=false)]
                public bool? Changed { get; set; }

                [NameInMap("changed_price")]
                [Validation(Required=false)]
                public IntlFlightInventoryPriceCheckResponseBodyModulePassengerChangedPriceInfoListChangedPrice ChangedPrice { get; set; }
                public class IntlFlightInventoryPriceCheckResponseBodyModulePassengerChangedPriceInfoListChangedPrice : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12000</para>
                    /// </summary>
                    [NameInMap("tax_price")]
                    [Validation(Required=false)]
                    public long? TaxPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>90000</para>
                    /// </summary>
                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public long? TicketPrice { get; set; }

                }

                [NameInMap("original_price")]
                [Validation(Required=false)]
                public IntlFlightInventoryPriceCheckResponseBodyModulePassengerChangedPriceInfoListOriginalPrice OriginalPrice { get; set; }
                public class IntlFlightInventoryPriceCheckResponseBodyModulePassengerChangedPriceInfoListOriginalPrice : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12000</para>
                    /// </summary>
                    [NameInMap("tax_price")]
                    [Validation(Required=false)]
                    public long? TaxPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>80000</para>
                    /// </summary>
                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public long? TicketPrice { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("passenger_type")]
                [Validation(Required=false)]
                public int? PassengerType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fcoid_deb6372db8194f1c94c23bc4fadc508d</para>
            /// </summary>
            [NameInMap("render_key")]
            [Validation(Required=false)]
            public string RenderKey { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>92359A00-85D8-16C4-AED0-249618DEEC17</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2103ad1516839612078738332dea5c</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
