// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeDeliveryAddressResponseBody : TeaModel {
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<DescribeDeliveryAddressResponseBodyAddresses> Addresses { get; set; }
        public class DescribeDeliveryAddressResponseBodyAddresses : TeaModel {
            [NameInMap("Area")]
            [Validation(Required=false)]
            public DescribeDeliveryAddressResponseBodyAddressesArea Area { get; set; }
            public class DescribeDeliveryAddressResponseBodyAddressesArea : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>33****</para>
                /// </summary>
                [NameInMap("AreaId")]
                [Validation(Required=false)]
                public long? AreaId { get; set; }

                [NameInMap("AreaName")]
                [Validation(Required=false)]
                public string AreaName { get; set; }

            }

            [NameInMap("City")]
            [Validation(Required=false)]
            public DescribeDeliveryAddressResponseBodyAddressesCity City { get; set; }
            public class DescribeDeliveryAddressResponseBodyAddressesCity : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>33****</para>
                /// </summary>
                [NameInMap("CityId")]
                [Validation(Required=false)]
                public long? CityId { get; set; }

                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Alice</para>
            /// </summary>
            [NameInMap("Contacts")]
            [Validation(Required=false)]
            public string Contacts { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DefaultAddress")]
            [Validation(Required=false)]
            public bool? DefaultAddress { get; set; }

            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1381111****</para>
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>03****</para>
            /// </summary>
            [NameInMap("PostalCode")]
            [Validation(Required=false)]
            public string PostalCode { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public DescribeDeliveryAddressResponseBodyAddressesProvince Province { get; set; }
            public class DescribeDeliveryAddressResponseBodyAddressesProvince : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>330000</para>
                /// </summary>
                [NameInMap("ProvinceId")]
                [Validation(Required=false)]
                public long? ProvinceId { get; set; }

                [NameInMap("ProvinceName")]
                [Validation(Required=false)]
                public string ProvinceName { get; set; }

            }

            [NameInMap("Town")]
            [Validation(Required=false)]
            public DescribeDeliveryAddressResponseBodyAddressesTown Town { get; set; }
            public class DescribeDeliveryAddressResponseBodyAddressesTown : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3001****</para>
                /// </summary>
                [NameInMap("TownId")]
                [Validation(Required=false)]
                public long? TownId { get; set; }

                [NameInMap("TownName")]
                [Validation(Required=false)]
                public string TownName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>72481C12-69AB-5CE1-8A35-A8EFA921****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
