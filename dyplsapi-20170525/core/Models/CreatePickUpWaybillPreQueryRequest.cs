// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreatePickUpWaybillPreQueryRequest : TeaModel {
        /// <summary>
        /// <para>The recipient information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ConsigneeInfo")]
        [Validation(Required=false)]
        public CreatePickUpWaybillPreQueryRequestConsigneeInfo ConsigneeInfo { get; set; }
        public class CreatePickUpWaybillPreQueryRequestConsigneeInfo : TeaModel {
            /// <summary>
            /// <para>The address information of the recipient.</para>
            /// </summary>
            [NameInMap("AddressInfo")]
            [Validation(Required=false)]
            public CreatePickUpWaybillPreQueryRequestConsigneeInfoAddressInfo AddressInfo { get; set; }
            public class CreatePickUpWaybillPreQueryRequestConsigneeInfoAddressInfo : TeaModel {
                /// <summary>
                /// <para>The detailed address of the recipient.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XX Community, No. XX</para>
                /// </summary>
                [NameInMap("AddressDetail")]
                [Validation(Required=false)]
                public string AddressDetail { get; set; }

                /// <summary>
                /// <para>The district where the recipient is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Chang\&quot;an District</para>
                /// </summary>
                [NameInMap("AreaName")]
                [Validation(Required=false)]
                public string AreaName { get; set; }

                /// <summary>
                /// <para>The city where the recipient is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Xi\&quot;an</para>
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>The province where the recipient is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Shaanxi Province</para>
                /// </summary>
                [NameInMap("ProvinceName")]
                [Validation(Required=false)]
                public string ProvinceName { get; set; }

                /// <summary>
                /// <para>The street where the recipient is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XX Street</para>
                /// </summary>
                [NameInMap("TownName")]
                [Validation(Required=false)]
                public string TownName { get; set; }

            }

            /// <summary>
            /// <para>The mobile phone number of the recipient.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1390000****</para>
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// <para>The name of the recipient.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Li XX</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The courier company code. If not specified, the system automatically assigns a courier company.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YTO</para>
        /// </summary>
        [NameInMap("CpCode")]
        [Validation(Required=false)]
        public string CpCode { get; set; }

        /// <summary>
        /// <para>The external channel source identifier. The value cannot contain underscores. The value is agreed upon with the system during integration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("OrderChannels")]
        [Validation(Required=false)]
        public string OrderChannels { get; set; }

        /// <summary>
        /// <para>The order number in the caller\&quot;s system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>787DFHHDS989****</para>
        /// </summary>
        [NameInMap("OuterOrderCode")]
        [Validation(Required=false)]
        public string OuterOrderCode { get; set; }

        /// <summary>
        /// <para>The estimated weight, in grams.</para>
        /// <remarks>
        /// <para>If you want to query the estimated price, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("PreWeight")]
        [Validation(Required=false)]
        public string PreWeight { get; set; }

        /// <summary>
        /// <para>The sender information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SenderInfo")]
        [Validation(Required=false)]
        public CreatePickUpWaybillPreQueryRequestSenderInfo SenderInfo { get; set; }
        public class CreatePickUpWaybillPreQueryRequestSenderInfo : TeaModel {
            /// <summary>
            /// <para>The address information of the sender.</para>
            /// </summary>
            [NameInMap("AddressInfo")]
            [Validation(Required=false)]
            public CreatePickUpWaybillPreQueryRequestSenderInfoAddressInfo AddressInfo { get; set; }
            public class CreatePickUpWaybillPreQueryRequestSenderInfoAddressInfo : TeaModel {
                /// <summary>
                /// <para>The detailed address of the sender.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XX Community, No. XX</para>
                /// </summary>
                [NameInMap("AddressDetail")]
                [Validation(Required=false)]
                public string AddressDetail { get; set; }

                /// <summary>
                /// <para>The district where the sender is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Xihu District</para>
                /// </summary>
                [NameInMap("AreaName")]
                [Validation(Required=false)]
                public string AreaName { get; set; }

                /// <summary>
                /// <para>The city where the sender is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou</para>
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>The province where the sender is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhejiang Province</para>
                /// </summary>
                [NameInMap("ProvinceName")]
                [Validation(Required=false)]
                public string ProvinceName { get; set; }

                /// <summary>
                /// <para>The street where the sender is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XX Street</para>
                /// </summary>
                [NameInMap("TownName")]
                [Validation(Required=false)]
                public string TownName { get; set; }

            }

            /// <summary>
            /// <para>The mobile phone number of the sender.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1390000****</para>
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// <para>The name of the sender.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Wang XX</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
