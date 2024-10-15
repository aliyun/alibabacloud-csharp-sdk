// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MealOrderListQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>noPermission</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public MealOrderListQueryResponseBodyModule Module { get; set; }
        public class MealOrderListQueryResponseBodyModule : TeaModel {
            [NameInMap("order_list")]
            [Validation(Required=false)]
            public List<MealOrderListQueryResponseBodyModuleOrderList> OrderList { get; set; }
            public class MealOrderListQueryResponseBodyModuleOrderList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("corp_pay_amount")]
                [Validation(Required=false)]
                public long? CorpPayAmount { get; set; }

                [NameInMap("merchant_name")]
                [Validation(Required=false)]
                public string MerchantName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1034124198083211043</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("order_status")]
                [Validation(Required=false)]
                public int? OrderStatus { get; set; }

                [NameInMap("order_type")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("pay_amount")]
                [Validation(Required=false)]
                public long? PayAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("person_pay_amount")]
                [Validation(Required=false)]
                public long? PersonPayAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1711705057</para>
                /// </summary>
                [NameInMap("settle_time")]
                [Validation(Required=false)]
                public string SettleTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
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
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
