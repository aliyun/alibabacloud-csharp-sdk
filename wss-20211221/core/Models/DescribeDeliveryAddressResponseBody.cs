// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeDeliveryAddressResponseBody : TeaModel {
        /// <summary>
        /// <para>The address list.</para>
        /// </summary>
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<DescribeDeliveryAddressResponseBodyAddresses> Addresses { get; set; }
        public class DescribeDeliveryAddressResponseBodyAddresses : TeaModel {
            /// <summary>
            /// <para>The area.</para>
            /// </summary>
            [NameInMap("Area")]
            [Validation(Required=false)]
            public DescribeDeliveryAddressResponseBodyAddressesArea Area { get; set; }
            public class DescribeDeliveryAddressResponseBodyAddressesArea : TeaModel {
                /// <summary>
                /// <para>The area ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33****</para>
                /// </summary>
                [NameInMap("AreaId")]
                [Validation(Required=false)]
                public long? AreaId { get; set; }

                /// <summary>
                /// <para>The area name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>西湖区</para>
                /// </summary>
                [NameInMap("AreaName")]
                [Validation(Required=false)]
                public string AreaName { get; set; }

            }

            /// <summary>
            /// <para>The city.</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public DescribeDeliveryAddressResponseBodyAddressesCity City { get; set; }
            public class DescribeDeliveryAddressResponseBodyAddressesCity : TeaModel {
                /// <summary>
                /// <para>The city ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33****</para>
                /// </summary>
                [NameInMap("CityId")]
                [Validation(Required=false)]
                public long? CityId { get; set; }

                /// <summary>
                /// <para>The city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州市</para>
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

            }

            /// <summary>
            /// <para>The contact name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alice</para>
            /// </summary>
            [NameInMap("Contacts")]
            [Validation(Required=false)]
            public string Contacts { get; set; }

            /// <summary>
            /// <para>Indicates whether this is the default address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DefaultAddress")]
            [Validation(Required=false)]
            public bool? DefaultAddress { get; set; }

            /// <summary>
            /// <para>The detailed address, which should include the street name and house number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>灯彩街1008号云园区2号楼测试中心</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The mobile number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1381111****</para>
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// <para>The postal code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>03****</para>
            /// </summary>
            [NameInMap("PostalCode")]
            [Validation(Required=false)]
            public string PostalCode { get; set; }

            /// <summary>
            /// <para>The province.</para>
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public DescribeDeliveryAddressResponseBodyAddressesProvince Province { get; set; }
            public class DescribeDeliveryAddressResponseBodyAddressesProvince : TeaModel {
                /// <summary>
                /// <para>The province ID. For more information, see <a href="https://help.aliyun.com/document_detail/167926.html">China regions, countries and territories codes</a>.</para>
                /// <para>For example, <b>110000</b> represents Beijing and <b>120000</b> represents Tianjin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>330000</para>
                /// </summary>
                [NameInMap("ProvinceId")]
                [Validation(Required=false)]
                public long? ProvinceId { get; set; }

                /// <summary>
                /// <para>The province name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>浙江省</para>
                /// </summary>
                [NameInMap("ProvinceName")]
                [Validation(Required=false)]
                public string ProvinceName { get; set; }

            }

            /// <summary>
            /// <para>The town.</para>
            /// </summary>
            [NameInMap("Town")]
            [Validation(Required=false)]
            public DescribeDeliveryAddressResponseBodyAddressesTown Town { get; set; }
            public class DescribeDeliveryAddressResponseBodyAddressesTown : TeaModel {
                /// <summary>
                /// <para>The town ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3001****</para>
                /// </summary>
                [NameInMap("TownId")]
                [Validation(Required=false)]
                public long? TownId { get; set; }

                /// <summary>
                /// <para>The town name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>三墩镇</para>
                /// </summary>
                [NameInMap("TownName")]
                [Validation(Required=false)]
                public string TownName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates this unique identifier for each request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72481C12-69AB-5CE1-8A35-A8EFA921****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count of addresses.</para>
        /// <remarks>
        /// <para>Up to 20 addresses are supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
