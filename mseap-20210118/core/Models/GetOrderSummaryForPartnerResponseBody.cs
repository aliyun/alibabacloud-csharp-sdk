// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mseap20210118.Models
{
    public class GetOrderSummaryForPartnerResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOrderSummaryForPartnerResponseBodyData Data { get; set; }
        public class GetOrderSummaryForPartnerResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>UShMru9tcC0RHD/04O0x1OrVkEJOq804ccSkgXSuZH0/42FlhtzyCKa6FofPs8n0</para>
            /// </summary>
            [NameInMap("EncryptedBuyerId")]
            [Validation(Required=false)]
            public string EncryptedBuyerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UShMru9tcC0RHD/04O0x1OrVkEJOq804ccSkgXSuZH0/42FlhtzyCKa6FofPs8n0</para>
            /// </summary>
            [NameInMap("EncryptedPayerId")]
            [Validation(Required=false)]
            public string EncryptedPayerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UShMru9tcC0RHD/04O0x1OrVkEJOq804ccSkgXSuZH0/42FlhtzyCKa6FofPs8n0</para>
            /// </summary>
            [NameInMap("EncryptedUserId")]
            [Validation(Required=false)]
            public string EncryptedUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11350044</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("OrderLines")]
            [Validation(Required=false)]
            public List<GetOrderSummaryForPartnerResponseBodyDataOrderLines> OrderLines { get; set; }
            public class GetOrderSummaryForPartnerResponseBodyDataOrderLines : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ob4twsebrj1734</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11350044</para>
                /// </summary>
                [NameInMap("OrderLineId")]
                [Validation(Required=false)]
                public string OrderLineId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>UPGRADE</para>
                /// </summary>
                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>56B009EB-AAA5-52C9-B05F-AF425E3885E8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
